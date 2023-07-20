using CSharpComposer;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using VulkanNative.Generator.Registries;
using VulkanNative.Generator.Registry;

namespace VulkanNative.Generator.Generators;

internal class BitMaskGenerator : ITypeGenerator
{
    private readonly TypeLocator _typeLocator;
    private readonly DocumentRegistry _documentRegistry;

    public BitMaskGenerator(TypeLocator typeLocator, DocumentRegistry documentRegistry)
    {
        _typeLocator = typeLocator;
        _documentRegistry = documentRegistry;
    }

    public TypeSyntax GenerateType(string typeName, VkType bitmaskDefinition)
    {
        if (!string.IsNullOrEmpty(bitmaskDefinition.Alias))
        {
            return _typeLocator.LookupType(bitmaskDefinition.Alias, alternativeName: typeName);
        }
        if (!string.IsNullOrEmpty(bitmaskDefinition.Requires))
        {
            return _typeLocator.LookupType(bitmaskDefinition.Requires, alternativeName: typeName);
        }
        else
        {
            // Bitmask does not have any enumerations, create an empty bitmask enum

            var compilationUnit = CSharpFactory.CompilationUnit(x => x
                .AddFileScopedNamespaceDeclaration("VulkanNative", x =>
                    x.AddEnumDeclaration(
                        typeName,
                        x => x
                            .AddSimpleBaseType("uint")
                            .AddModifierToken(SyntaxKind.PublicKeyword)
                            .AddAttribute("Flags")
                            .AddEnumMemberDeclaration("None", x => x.WithEqualsValue("1U << 0"))
                    )
                )
            );

            _documentRegistry.Documents.Add($"Enums/{typeName}.cs", compilationUnit);

            return CSharpFactory.Type(typeName);
        }

        
    }
}