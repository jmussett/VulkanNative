using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Numerics;
using VulkanNative.Generator.Builder.Types;
using VulkanNative.Generator.Builder.Validators;

namespace VulkanNative.Generator.Builder.Builders;

public interface IEnumDeclarationBuilder : IBaseTypeDeclarationBuilder<IEnumDeclarationBuilder>
{
    IEnumDeclarationBuilder WithMember(string identifier, Action<IExpressionBuilder>? expressionCallback = null);
}

public class EnumDeclarationBuilder : IEnumDeclarationBuilder
{
    private BaseTypeDeclarationBuilder _baseTypeBuilder;

    public EnumDeclarationSyntax Syntax
    {
        get => (EnumDeclarationSyntax)_baseTypeBuilder.Syntax;
        set => _baseTypeBuilder.Syntax = value;
    }

    public EnumDeclarationBuilder(EnumDeclarationSyntax syntax)
    {
        _baseTypeBuilder = new BaseTypeDeclarationBuilder(syntax, AttributeTargets.Enum);
    }

    public static EnumDeclarationSyntax CreateSyntax(
        string identifier,
        Func<IEnumDeclarationBuilder, IEnumDeclarationBuilder> enumCallback,
        Func<ITypeBuilder, ITypeBuilder>? typeCallback = null
    )
    {
        SyntaxValidator.ValidateIdentifier(identifier);

        var enumSyntax = SyntaxFactory.EnumDeclaration(identifier);

        if (typeCallback is not null)
        {
            var typeSyntax = TypeBuilder.CreateSyntax(typeCallback);

            enumSyntax = enumSyntax.WithBaseList(
                SyntaxFactory.BaseList(
                    SyntaxFactory.SingletonSeparatedList<BaseTypeSyntax>(
                        SyntaxFactory.SimpleBaseType(
                            typeSyntax
                        )
                    )
                )
            );
        }

        var builder = new EnumDeclarationBuilder(enumSyntax).AssertInvoke(enumCallback);

        return builder.Syntax;
    }

    // TODO: WithDocumentation?

    // TODO: Add EnumMemberBuilder?
    // - WithDocumentation
    // - WithValue
    // - WithAttribute

    public IEnumDeclarationBuilder WithMember(string identifier, Action<IExpressionBuilder>? expressionCallback = null)
    {
        SyntaxValidator.ValidateIdentifier(identifier);

        var enumMemberDeclaration = SyntaxFactory.EnumMemberDeclaration(identifier);

        if (expressionCallback is not null)
        {
            var expressionSyntax = ExpressionBuilder.CreateSyntax(expressionCallback);

            enumMemberDeclaration = enumMemberDeclaration
                .WithEqualsValue(
                    SyntaxFactory.EqualsValueClause(expressionSyntax)
                );
        }

        Syntax = Syntax.AddMembers(enumMemberDeclaration);

        return this;
    }

    public IEnumDeclarationBuilder WithAccessModifier(TypeAccessModifier accessModifier)
    {
        _baseTypeBuilder = _baseTypeBuilder.AssertInvoke(x => x.WithAccessModifier(accessModifier));

        return this;
    }

    public IEnumDeclarationBuilder WithAttribute(Func<INameBuilder, INameBuilder> nameCallback, Func<IAttributeBuilder, IAttributeBuilder>? attributeCallback = null)
    {
        _baseTypeBuilder = _baseTypeBuilder.AssertInvoke(x => x.WithAttribute(nameCallback, attributeCallback));

        return this;
    }

    public IEnumDeclarationBuilder WithAttribute(Type type, Func<IAttributeBuilder, IAttributeBuilder>? attributeCallback = null)
    {
        _baseTypeBuilder = _baseTypeBuilder.AssertInvoke(x => x.WithAttribute(type, attributeCallback));

        return this;
    }

    public IEnumDeclarationBuilder WithUnsafeModifier()
    {
        _baseTypeBuilder = _baseTypeBuilder.AssertInvoke(x => x.WithUnsafeModifier());

        return this;
    }
}
