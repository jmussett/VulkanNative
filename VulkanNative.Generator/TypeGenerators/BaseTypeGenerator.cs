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
    private readonly TypeLocator _typeLocator;

    public BaseTypeGenerator(DocumentRegistry documentRegistry, TypeLocator typeLocator)
    {
        _documentRegistry = documentRegistry;
        _typeLocator = typeLocator;
    }

    public TypeSyntax GenerateType(string typeName, VkType baseTypeDefinition)
    {
        var underlyingTypeSyntax = _typeLocator.LookupType(baseTypeDefinition.Types[0]);

        var compilationUnit = CSharpFactory.CompilationUnit(x => x
            .AddUsingDirective("System.Runtime.InteropServices")
            .AddFileScopedNamespaceDeclaration("VulkanNative", x => x
                .AddStructDeclaration(typeName, x => x
                    .AddModifierToken(SyntaxKind.PublicKeyword)
                    .AddModifierToken(SyntaxKind.ReadOnlyKeyword)
                    .AddAttribute("StructLayout", x => x.AddAttributeArgument("LayoutKind.Sequential")) //TODO add extension for literal arguments 
                    .AddFieldDeclaration(
                        x => x.FromSyntax(underlyingTypeSyntax),
                        x => x.AddVariableDeclarator("_value"),
                        x => x
                            .AddModifierToken(SyntaxKind.PrivateKeyword)
                            .AddModifierToken(SyntaxKind.ReadOnlyKeyword)
                    )
                    .AddConstructorDeclaration(typeName, x => x
                        .AddParameter("value", x => x.WithType(underlyingTypeSyntax))
                        .AddModifierToken(SyntaxKind.PublicKeyword)
                        .WithBody(x => x
                            .AddExpressionStatement(x => x
                                .AsAssignmentExpression(
                                    AssignmentExpressionKind.SimpleAssignmentExpression,
                                    x => x.AsIdentifierName("_value"),
                                    x => x.AsIdentifierName("value")
                                )
                            )
                        )
                    )
                    .AddMemberDeclaration(x => x
                        .AsConversionOperatorDeclaration(
                            ConversionOperatorDeclarationImplicitOrExplicitKeyword.ImplicitKeyword,
                            x => x.ParseTypeName(typeName),
                            x => x
                                .AddModifierToken(SyntaxKind.PublicKeyword)
                                .AddModifierToken(SyntaxKind.StaticKeyword)
                                .AddParameter("value", x => x.WithType(underlyingTypeSyntax))
                                .WithBody(x => x
                                    .AddReturnStatement(
                                        x => x.WithExpression($"new {typeName}(value)")
                                    )
                                )
                        )
                    )
                    .AddMemberDeclaration(x => x
                        .AsConversionOperatorDeclaration(
                            ConversionOperatorDeclarationImplicitOrExplicitKeyword.ImplicitKeyword,
                            x => x.FromSyntax(underlyingTypeSyntax),
                            x => x
                                .AddModifierToken(SyntaxKind.PublicKeyword)
                                .AddModifierToken(SyntaxKind.StaticKeyword)
                                .AddParameter("value", x => x.WithType(typeName))
                                .WithBody(x => x
                                    .AddReturnStatement(
                                        x => x.WithExpression($"value._value")
                                    )
                                )
                        )
                    )
                )
            )
        );

        _documentRegistry.Documents.Add($"BaseTypes/{typeName}.cs", compilationUnit);

        return CSharpFactory.Type(typeName);
    }
}
