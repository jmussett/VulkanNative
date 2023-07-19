using CSharpComposer;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using VulkanNative.Generator.Registries;
using VulkanNative.Generator.Registry;

namespace VulkanNative.Generator.Generators;

internal class EnumGenerator : ITypeGenerator
{
    private readonly DocumentRegistry _documentRegistry;
    private readonly IDictionary<string, VkEnums> _enumRegistry;

    public EnumGenerator(DocumentRegistry documentRegistry, VkRegistry vkRegistry)
    {
        _documentRegistry = documentRegistry;
        _enumRegistry = vkRegistry.Enums.ToDictionary(x => x.Name, x => x);
    }

    public TypeSyntax GenerateType(VkType enumTypeDefinition)
    {
        var enumName = enumTypeDefinition.NameAttribute;

        if (!_enumRegistry.TryGetValue(enumName, out var enumDefinition))
        {
            throw new InvalidOperationException($"Unable to find enum '{enumName}'");
        }

        /*
        - enum types with a bitwidth of 32 (or no bitwidth) will be int32_t, or an 'int' in c#
        - enum types with a bitwidth of 64 will be int64_t, or a 'long' in c#
        - bitmask types with a bitwidth of 32 (or no bitwidth) will be uint32_t, or a 'uint' in c#
        - bitmask types with a bitwidth of 64 will be uint64_t, or a 'ulong' in c#
        */

        var enumType = enumDefinition.Type switch
        {
            "enum" => "int",
            "bitmask" => enumDefinition.BitWidth == "64" ? "ulong" : "uint",
            _ => throw new InvalidOperationException()
        };

        var compilationUnit = CSharpFactory.CompilationUnit(x => x
            .AddFileScopedNamespaceDeclaration("VulkanNative", x =>
                x.AddEnumDeclaration(
                    enumName,
                    x =>
                    {
                        x.AddSimpleBaseType(enumType);
                        x.AddModifierToken(SyntaxKind.PublicKeyword);

                        if (enumDefinition.Type == "bitmask")
                        {
                            x = x.AddAttribute("Flags");
                        }

                        foreach (var enumMember in enumDefinition.Enums)
                        {
                            // TODO: comments

                            var enumValue = enumMember.Value is not null
                                ? enumMember.Value
                                : enumMember.Bitpos;

                            x = enumValue is not null
                                ? x.AddEnumMemberDeclaration(enumMember.Name, x => x.WithEqualsValue(enumValue))
                                : x.AddEnumMemberDeclaration(enumMember.Name);
                        }
                    }
                )
            )
        );

        _documentRegistry.Documents.Add($"Enums/{enumName}.cs", compilationUnit);

        return CSharpFactory.Type(enumName);
    }
}
