using CSharpComposer;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
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

    public void GenerateType(VkType unionDefinition)
    {
        var compilationUnit = CSharpFactory.CompilationUnit(x =>
            x.AddFileScopedNamespaceDeclaration("VulkanNative", x =>
                x.AddStructDeclaration(unionDefinition.NameAttribute, x => x.AddModifierToken(SyntaxKind.PublicKeyword)) // TODO: Add fields.
            )
        );

        _documentRegistry.Documents.Add($"Unions/{unionDefinition.NameAttribute}.cs", compilationUnit);
    }
}
