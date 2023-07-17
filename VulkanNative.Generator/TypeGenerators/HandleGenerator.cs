using CSharpComposer;
using Microsoft.CodeAnalysis.CSharp;
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

    public void GenerateType(VkType handleDefinition)
    {
        var compilationUnit = CSharpFactory.CompilationUnit(x => x
            .AddUsingDirective("System.Runtime.InteropServices")
            .AddFileScopedNamespaceDeclaration("VulkanNative", x =>
                x.AddStructDeclaration(handleDefinition.Name, x => x
                    .AddModifierToken(SyntaxKind.PublicKeyword)
                    .AddModifierToken(SyntaxKind.ReadOnlyKeyword)
                    .AddAttribute("StructLayout", x => x.AddAttributeArgument("LayoutKind.Sequential")) //TODO add extension for literal arguments 
                    .AddFieldDeclaration("nint",
                        x => x.AddVariableDeclarator("_handle"),
                        x => x
                            .AddModifierToken(SyntaxKind.PrivateKeyword)
                            .AddModifierToken(SyntaxKind.ReadOnlyKeyword)
                    )
                    .AddConstructorDeclaration(handleDefinition.Name, x => x
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
                            x => x.ParseTypeName(handleDefinition.Name),
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
                                .AddParameter("value", x => x.WithType(handleDefinition.Name))
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

        _documentRegistry.Documents.Add($"Handles/{handleDefinition.Name}.cs", compilationUnit);
    }
}