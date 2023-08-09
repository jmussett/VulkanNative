using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VulkanNative.Generator;

internal class TypeDefinition
{
    public TypeSyntax Syntax { get; set; }

    public SyntaxKind[] Modifiers { get; set; } = Array.Empty<SyntaxKind>();
    public ExpressionSyntax[] Arguments { get; set; } = Array.Empty<ExpressionSyntax>();

    public TypeDefinition(TypeSyntax syntax)
    {
        Syntax = syntax;
    }

    public static implicit operator TypeDefinition(TypeSyntax syntax)
    {
        return new TypeDefinition(syntax);
    }

    public static implicit operator TypeSyntax(TypeDefinition definition)
    {
        if (definition.Modifiers.Length > 0 || definition.Arguments.Length > 0)
        {
            throw new InvalidOperationException("Cannot cast definition to type syntax. Type contains modifiers and arguments.");
        }

        return definition.Syntax;
    }
}
