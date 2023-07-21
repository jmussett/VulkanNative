using CSharpComposer;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using VulkanNative.Generator.Registries;
using VulkanNative.Generator.Registry;

namespace VulkanNative.Generator.Generators;

internal class UnionGenerator : ITypeGenerator
{
    private readonly TypeLocator _typeLocator;
    private readonly DocumentRegistry _documentRegistry;

    public UnionGenerator(TypeLocator typeLocator, DocumentRegistry documentRegistry)
    {
        _typeLocator = typeLocator;
        _documentRegistry = documentRegistry;
    }

    public TypeSyntax GenerateType(string typeName, VkType unionDefinition)
    {
        var compilationUnit = CSharpFactory.CompilationUnit(x => x
            .AddUsingDirective("System.Runtime.InteropServices")
            .AddFileScopedNamespaceDeclaration("VulkanNative", x =>
                x.AddStructDeclaration(typeName, x =>
                {
                    x.AddAttribute("StructLayout", x => x.AddAttributeArgument("LayoutKind.Explicit"));
                    x.AddModifierToken(SyntaxKind.PublicKeyword);
                    x.AddModifierToken(SyntaxKind.UnsafeKeyword);

                    foreach (var member in unionDefinition.Members)
                    {
                        var fieldType = _typeLocator.LookupType(member.Type);

                        // TODO: CSharpComposer: optional field builder?
                        x.AddFieldDeclaration(
                            x => x.FromSyntax(fieldType),
                            x => x.AddVariableDeclarator(member.Name),
                            x => x
                                .AddModifierToken(SyntaxKind.PublicKeyword)
                                .AddAttribute("FieldOffset", x => x.AddAttributeArgument("0"))
                        );
                    }
                })
            )
        );

        _documentRegistry.Documents.Add($"Unions/{typeName}.cs", compilationUnit);

        return CSharpFactory.Type(typeName);
    }
}
