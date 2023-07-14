using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using VulkanNative.Generator.Builder.Validators;

namespace VulkanNative.Generator.Builder.Builders;

public interface IParameterBuilder
{
    IParameterBuilder WithAttribute(Func<INameBuilder, INameBuilder> nameCallback, Func<IAttributeBuilder, IAttributeBuilder> attributeCallback);
}

public sealed class ParameterBuilder : IParameterBuilder
{
    public ParameterSyntax Syntax { get; set; }

    public ParameterBuilder(ParameterSyntax syntax)
    {
        Syntax = syntax;
    }

    public static ParameterSyntax CreateSyntax(
        string identifier,
        Func<ITypeBuilder, ITypeBuilder> typeCallback,
        Func<IParameterBuilder, IParameterBuilder>? parameterCallback = null
    )
    {
        SyntaxValidator.ValidateIdentifier(identifier);

        var typeSyntax = TypeBuilder.CreateSyntax(typeCallback);

        var parameterSyntax = SyntaxFactory.Parameter(SyntaxFactory.Identifier(identifier))
            .WithType(typeSyntax);

        if (parameterCallback is not null)
        {
            var builder = new ParameterBuilder(parameterSyntax).AssertInvoke(parameterCallback);

            parameterSyntax = builder.Syntax;
        }

        return parameterSyntax;
    }

    // TODO: name extension
    public IParameterBuilder WithAttribute(Func<INameBuilder, INameBuilder> nameCallback, Func<IAttributeBuilder, IAttributeBuilder> attributeCallback)
    {
        var attributeSyntax = AttributeBuilder.CreateSyntax(nameCallback, attributeCallback);

        Syntax = Syntax.AddAttributeLists(
            SyntaxFactory.AttributeList(
                SyntaxFactory.SingletonSeparatedList(attributeSyntax)
            )
        );

        return this;
    }

    // TODO: ref, out, in, params

    // TODO: optional / default ?
}