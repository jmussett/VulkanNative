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

    public TypeDefinition LookupType(string type, string? postTypeData = null, string? alternativeName = null)
    {
        if (type == "void" && string.IsNullOrEmpty(postTypeData))
        {
            return CSharpFactory.Type(x => x.AsPredefinedType(PredefinedTypeKeyword.VoidKeyword));
        }

        var pointerRank = postTypeData?.Count(c => c == '*') ?? 0;

        if (pointerRank > 0)
        {
            return CSharpFactory.Type(x => BuildPointerType(x, type, alternativeName, pointerRank));
        }

        // Check for fixed size buffer pattern
        var arrayMatch = Regex.Match(postTypeData ?? string.Empty, @"\[([a-zA-Z0-9_]+)\]");
        if (arrayMatch.Success)
        {
            TypeSyntax underlyingType = LookupType(type, null, alternativeName);

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

        if (_typeRegistry.Types.TryGetValue(alternativeName ?? type, out var typeSyntax))
        {
            return typeSyntax;
        }

        var vkType = _vkRegistry.Types.FirstOrDefault(x => x.Name == type)
            ?? _vkRegistry.Types.FirstOrDefault(x => x.NameAttribute == type)
            ?? throw new InvalidOperationException($"Unable to find type '{type}'");

        typeSyntax = _generatorRegistry.GenerateType(alternativeName ?? type, vkType);

        _typeRegistry.Types.TryAdd(alternativeName ?? type, typeSyntax);

        return typeSyntax;
    }

    private void BuildPointerType(ITypeBuilder typeBuilder, string typeName, string? alternativeName, int pointerRank)
    {
        if (pointerRank == 0)
        {
            typeBuilder.FromSyntax(LookupType(typeName, null, alternativeName));
        }
        else
        {
            typeBuilder.AsPointerType(x => BuildPointerType(x, typeName, alternativeName, pointerRank - 1));
        }
    }
}
