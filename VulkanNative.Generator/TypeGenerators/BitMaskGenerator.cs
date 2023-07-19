using CSharpComposer;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using VulkanNative.Generator.Registries;
using VulkanNative.Generator.Registry;

namespace VulkanNative.Generator.Generators;

internal class BitMaskGenerator : ITypeGenerator
{
    private readonly DocumentRegistry _documentRegistry;

    public BitMaskGenerator(DocumentRegistry documentRegistry)
    {
        _documentRegistry = documentRegistry;
    }

    public TypeSyntax GenerateType(VkType bitmaskDefinition)
    {
        var bitmaskName = bitmaskDefinition.Name;

        var bitmaskCompilationUnit = CSharpFactory.CompilationUnit(x =>
            x.AddFileScopedNamespaceDeclaration("VulkanNative", ns =>
                ns.AddStructDeclaration(bitmaskName, st =>
                    st.AddModifierToken(SyntaxKind.PublicKeyword)
                ) // TODO: Add fields.
            )
        );

        _documentRegistry.Documents.Add($"Bitmasks/{bitmaskName}.cs", bitmaskCompilationUnit);

        return CSharpFactory.Type(bitmaskName);
    }
}