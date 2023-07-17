using CSharpComposer;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using VulkanNative.Generator.Registries;
using VulkanNative.Generator.Registry;

namespace VulkanNative.Generator.Generators;

internal class FuncPointerGenerator : ITypeGenerator
{
    private readonly DocumentRegistry _documentRegistry;

    public FuncPointerGenerator(DocumentRegistry documentRegistry)
    {
        _documentRegistry = documentRegistry;
    }

    public void GenerateType(VkType funcPointerDefinition)
    {
        var compilationUnit = CSharpFactory.CompilationUnit(x =>
            x.AddFileScopedNamespaceDeclaration("VulkanNative", x =>
                x.AddStructDeclaration(funcPointerDefinition.Name, x => x.AddModifierToken(SyntaxKind.PublicKeyword)) // TODO: Add fields.
            )
        );

        _documentRegistry.Documents.Add($"Functions/{funcPointerDefinition.Name}.cs", compilationUnit);
    }
}
