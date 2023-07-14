using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using VulkanNative.Generator.Builder.Validators;

namespace VulkanNative.Generator.Builder.Builders;

public static class VariableDeclaratorBuilder
{

    public static VariableDeclaratorSyntax CreateSyntax(string identifier)
    {
        SyntaxValidator.ValidateIdentifier(identifier);

        return SyntaxFactory.VariableDeclarator(
            SyntaxFactory.Identifier(identifier)
        );
    }
}