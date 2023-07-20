using CSharpComposer;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using VulkanNative.Generator.Registries;
using VulkanNative.Generator.Registry;

namespace VulkanNative.Generator.Generators;

internal class UnionGenerator : ITypeGenerator
{
    private readonly DocumentRegistry _documentRegistry;

    public UnionGenerator(DocumentRegistry documentRegistry)
    {
        _documentRegistry = documentRegistry;
    }

    public TypeSyntax GenerateType(string typeName, VkType unionDefinition)
    {
        var compilationUnit = CSharpFactory.CompilationUnit(x =>
            x.AddFileScopedNamespaceDeclaration("VulkanNative", x =>
                x.AddStructDeclaration(typeName, x => x.AddModifierToken(SyntaxKind.PublicKeyword)) // TODO: Add fields.
            )
        );

        _documentRegistry.Documents.Add($"Unions/{typeName}.cs", compilationUnit);

        return CSharpFactory.Type(typeName);
    }
}
