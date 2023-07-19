using CSharpComposer;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using VulkanNative.Generator.Registries;
using VulkanNative.Generator.Registry;

namespace VulkanNative.Generator.Generators;

internal class HandleGenerator : ITypeGenerator
{
    private readonly DocumentRegistry _documentRegistry;

    public HandleGenerator(DocumentRegistry documentRegistry)
    {
        _documentRegistry = documentRegistry;
    }

    public TypeSyntax GenerateType(VkType handleDefinition)
    {
        var handlerName = handleDefinition.Name;

        var compilationUnit = CSharpFactory.CompilationUnit(x => x
            .AddUsingDirective("System.Runtime.InteropServices")
            .AddFileScopedNamespaceDeclaration("VulkanNative", x =>
                x.AddStructDeclaration(handlerName, x => x
                    .AddModifierToken(SyntaxKind.PublicKeyword)
                    .AddModifierToken(SyntaxKind.ReadOnlyKeyword)
                    .AddAttribute("StructLayout", x => x.AddAttributeArgument("LayoutKind.Sequential")) //TODO add extension for literal arguments 
                    .AddFieldDeclaration("nint",
                        x => x.AddVariableDeclarator("_handle"),
                        x => x
                            .AddModifierToken(SyntaxKind.PrivateKeyword)
                            .AddModifierToken(SyntaxKind.ReadOnlyKeyword)
                    )
                    .AddConstructorDeclaration(handlerName, x => x
                        .AddParameter("handle", x => x.WithType("nint"))
                        .AddModifierToken(SyntaxKind.PublicKeyword)
                        .WithBody(x => x
                            .AddExpressionStatement(x => x
                                .AsAssignmentExpression(
                                    AssignmentExpressionKind.SimpleAssignmentExpression,
                                    x => x.AsIdentifierName("_handle"),
                                    x => x.AsIdentifierName("handle")
                                )
                            )
                        )
                    )
                    .AddMemberDeclaration(x => x
                        .AsConversionOperatorDeclaration(
                            ConversionOperatorDeclarationImplicitOrExplicitKeyword.ImplicitKeyword,
                            x => x.ParseTypeName(handlerName),
                            x => x
                                .AddModifierToken(SyntaxKind.PublicKeyword)
                                .AddModifierToken(SyntaxKind.StaticKeyword)
                                .AddParameter("handle", x => x.WithType("nint"))
                                .WithBody(x => x
                                    .AddReturnStatement(
                                        x => x.WithExpression($"new {handleDefinition.Name}(handle)")
                                    )
                                )
                        )
                    )
                    .AddMemberDeclaration(x => x
                        .AsConversionOperatorDeclaration(
                            ConversionOperatorDeclarationImplicitOrExplicitKeyword.ImplicitKeyword,
                            x => x.ParseTypeName("nint"),
                            x => x
                                .AddModifierToken(SyntaxKind.PublicKeyword)
                                .AddModifierToken(SyntaxKind.StaticKeyword)
                                .AddParameter("value", x => x.WithType(handlerName))
                                .WithBody(x => x
                                    .AddReturnStatement(
                                        x => x.WithExpression($"value._handle")
                                    )
                                )
                        )
                    )
                )
            )
        );

        _documentRegistry.Documents.Add($"Handles/{handlerName}.cs", compilationUnit);

        return CSharpFactory.Type(handlerName);
    }
}