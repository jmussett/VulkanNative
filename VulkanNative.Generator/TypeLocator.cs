using CSharpComposer;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Text.RegularExpressions;
using VulkanNative.Generator.Registries;
using VulkanNative.Generator.Registry;

namespace VulkanNative.Generator;

internal class TypeLocator
{
    private readonly VkRegistry _vkRegistry;
    private readonly TypeRegistry _typeRegistry;
    private readonly TypeGeneratorRegistry _generatorRegistry;

    public TypeLocator(VkRegistry vkRegistry, TypeRegistry typeRegistry, TypeGeneratorRegistry generatorRegistry)
    {
        _vkRegistry = vkRegistry;
        _typeRegistry = typeRegistry;
        _generatorRegistry = generatorRegistry;
    }

    public TypeDefinition LookupType(string type, string? postTypeData, Func<TypeDefinition> typeFactory)
    {
        if (type == "void" && string.IsNullOrEmpty(postTypeData))
        {
            return CSharpFactory.Type(x => x.AsPredefinedType(PredefinedTypeKeyword.VoidKeyword));
        }

        var pointerRank = postTypeData?.Count(c => c == '*') ?? 0;

        if (pointerRank > 0)
        {
            return CSharpFactory.Type(x => BuildPointerType(x, type, pointerRank, typeFactory));
        }

        // Check for fixed size buffer pattern
        var arrayMatch = Regex.Match(postTypeData ?? string.Empty, @"\[([a-zA-Z0-9_]+)\]");
        if (arrayMatch.Success)
        {
            TypeSyntax underlyingType = typeFactory();

            // Unfortunately only predefined types can be used for fixed size buffers (for now)
            // Use pointers for structs instead
            if (underlyingType is not PredefinedTypeSyntax)
            {
                return CSharpFactory.Type(x => x.AsPointerType(x => x.FromSyntax(underlyingType)));
            }

            if (int.TryParse(arrayMatch.Groups[1].Value, out int arraySize))
            {
                return new TypeDefinition(underlyingType)
                {
                    Modifiers = new[] { SyntaxKind.FixedKeyword },
                    Arguments = new[] { CSharpFactory.Expression(x => x.AsLiteralExpression(x => x.AsNumericLiteral(arraySize))) }
                };
            }
            else
            {
                return new TypeDefinition(underlyingType)
                {
                    Modifiers = new[] { SyntaxKind.FixedKeyword },
                    Arguments = new[] { CSharpFactory.Expression(x => x.ParseExpression($"(int) VulkanApiConstants.{arrayMatch.Groups[1].Value}")) }
                };
            }
        }

        return typeFactory();
    }

    public TypeDefinition LookupType(string type, string? postTypeData = null)
    {
        return LookupType(type, postTypeData, () =>
        {
            VkType vkType; 

            while(true)
            {
                if (_typeRegistry.Types.TryGetValue(type, out var existingSyntax))
                {
                    return existingSyntax;
                }

                vkType = _vkRegistry.Types.FirstOrDefault(x => x.Name == type)
                    ?? _vkRegistry.Types.FirstOrDefault(x => x.NameAttribute == type)
                    ?? throw new InvalidOperationException($"Unable to find type '{type}'");

                if (string.IsNullOrEmpty(vkType.Alias))
                {
                    break;
                }

                type = vkType.Alias;
            }

            var typeSyntax = _generatorRegistry.GenerateType(type, vkType);

            _typeRegistry.Types.TryAdd(type, typeSyntax);

            return typeSyntax;
        });
    }

    private void BuildPointerType(ITypeBuilder typeBuilder, string typeName, int pointerRank, Func<TypeDefinition> typeFactory)
    {
        if (pointerRank == 0)
        {
            typeBuilder.FromSyntax(typeFactory());
        }
        else
        {
            typeBuilder.AsPointerType(x => BuildPointerType(x, typeName, pointerRank - 1, typeFactory));
        }
    }
}
