using CSharpComposer;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using VulkanNative.Generator.Registries;
using VulkanNative.Generator.Registry;

namespace VulkanNative.Generator.Generators;

internal class BaseTypeGenerator : ITypeGenerator
{
    private readonly DocumentRegistry _documentRegistry;

    public BaseTypeGenerator(DocumentRegistry documentRegistry)
    {
        _documentRegistry = documentRegistry;
    }

    public void GenerateType(VkType baseTypeDefinition)
    {
        var baseTypeName = baseTypeDefinition.Name;

        var compilationUnit = CSharpFactory.CompilationUnit(x =>
            x.AddFileScopedNamespaceDeclaration("VulkanNative", x =>
                x.AddStructDeclaration(baseTypeName, x => x.AddModifierToken(SyntaxKind.PublicKeyword)) // TODO: Add fields.
            )
        );

        _documentRegistry.Documents.Add($"BaseTypes/{baseTypeName}.cs", compilationUnit);
    }
}
