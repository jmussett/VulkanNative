using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using VulkanNative.Generator.Builder.Types;
using VulkanNative.Generator.Builder.Validators;

namespace VulkanNative.Generator.Builder.Builders;

public interface IInterfaceDeclarationBuilder : ITypeDeclarationBuilder<IInterfaceDeclarationBuilder>
{
    IInterfaceDeclarationBuilder WithTypeParameter(string identifier, VarianceModifier varianceModifier, Func<ITypeParameterBuilder, ITypeParameterBuilder>? typeParameterCallback = null);
}

public sealed class InterfaceDeclarationBuilder : IInterfaceDeclarationBuilder
{
    private TypeDeclarationBuilder _typeDeclarationBuilder;

    public InterfaceDeclarationSyntax Syntax
    {
        get => (InterfaceDeclarationSyntax)_typeDeclarationBuilder.Syntax;
        set => _typeDeclarationBuilder.Syntax = value;
    }

    public InterfaceDeclarationBuilder(InterfaceDeclarationSyntax syntax)
    {
        _typeDeclarationBuilder = new(syntax, AttributeTargets.Interface);
    }

    public static InterfaceDeclarationSyntax CreateSyntax(string identifier, Func<IInterfaceDeclarationBuilder, IInterfaceDeclarationBuilder> interfaceCallback)
    {
        SyntaxValidator.ValidateIdentifier(identifier);

        var syntax = SyntaxFactory.InterfaceDeclaration(identifier);

        var builder = new InterfaceDeclarationBuilder(syntax).AssertInvoke(interfaceCallback);

        return builder.Syntax;
    }

    public IInterfaceDeclarationBuilder WithTypeParameter(string identifier, VarianceModifier varianceModifier, Func<ITypeParameterBuilder, ITypeParameterBuilder>? typeParameterCallback = null)
    {
        var (TypeParameter, ConstraintClause) = TypeParameterBuilder.CreateSyntax(identifier, varianceModifier, typeParameterCallback);

        Syntax = Syntax.AddTypeParameterListParameters(TypeParameter);

        if (ConstraintClause is not null)
        {
            Syntax = Syntax.AddConstraintClauses(ConstraintClause);
        }

        return this;
    }

    public IInterfaceDeclarationBuilder WithBaseType(Func<IBaseTypeBuilder, IBaseTypeBuilder> typeCallback)
    {
        _typeDeclarationBuilder = _typeDeclarationBuilder.AssertInvoke(x => x.WithBaseType(typeCallback));
        return this;
    }

    public IInterfaceDeclarationBuilder WithMethod(string identifier, Func<ITypeBuilder, ITypeBuilder> typeCallback, Func<IMethodDeclarationBuilder, IMethodDeclarationBuilder> methodCallback)
    {
        _typeDeclarationBuilder = _typeDeclarationBuilder.AssertInvoke(x => x.WithMethod(identifier, typeCallback, methodCallback));
        return this;
    }

    public IInterfaceDeclarationBuilder WithProperty(string identifier, Func<ITypeBuilder, ITypeBuilder> typeCallback, Func<IPropertyDeclarationBuilder, IPropertyDeclarationBuilder>? propertyCallback = null)
    {
        _typeDeclarationBuilder = _typeDeclarationBuilder.AssertInvoke(x => x.WithProperty(identifier, typeCallback, propertyCallback));
        return this;
    }

    public IInterfaceDeclarationBuilder WithTypeParameter(string identifier, Func<ITypeParameterBuilder, ITypeParameterBuilder>? typeParameterCallback = null)
    {
        _typeDeclarationBuilder = _typeDeclarationBuilder.AssertInvoke(x => x.WithTypeParameter(identifier, typeParameterCallback));
        return this;
    }

    public IInterfaceDeclarationBuilder WithAccessModifier(TypeAccessModifier accessModifier)
    {
        _typeDeclarationBuilder = _typeDeclarationBuilder.AssertInvoke(x => x.WithAccessModifier(accessModifier));
        return this;
    }

    public IInterfaceDeclarationBuilder WithAttribute(Func<INameBuilder, INameBuilder> nameCallback, Func<IAttributeBuilder, IAttributeBuilder>? attributeCallback = null)
    {
        _typeDeclarationBuilder = _typeDeclarationBuilder.AssertInvoke(x => x.WithAttribute(nameCallback, attributeCallback));
        return this;
    }

    public IInterfaceDeclarationBuilder WithAttribute(Type type, Func<IAttributeBuilder, IAttributeBuilder>? attributeCallback = null)
    {
        _typeDeclarationBuilder = _typeDeclarationBuilder.AssertInvoke(x => x.WithAttribute(type, attributeCallback));
        return this;
    }

    public IInterfaceDeclarationBuilder WithUnsafeModifier()
    {
        _typeDeclarationBuilder = _typeDeclarationBuilder.AssertInvoke(x => x.WithUnsafeModifier());
        return this;
    }
}

public static class InterfaceBuilderExtensions
{

    public static IInterfaceDeclarationBuilder WithMethod<T>(
        this IInterfaceDeclarationBuilder builder,
        string identifier,
        Func<IMethodDeclarationBuilder, IMethodDeclarationBuilder> methodCallback
    )
    {
        return builder.WithMethod(identifier, x => x.AsType<T>(), methodCallback);
    }

    public static IInterfaceDeclarationBuilder WithMethod(
        this IInterfaceDeclarationBuilder builder,
        string identifier,
        Func<IMethodDeclarationBuilder, IMethodDeclarationBuilder> methodCallback
    )
    {
        return builder.WithMethod(identifier, x => x.AsVoid(), methodCallback);
    }

    public static IInterfaceDeclarationBuilder WithProperty<T>(
        this IInterfaceDeclarationBuilder builder,
        string identifier,
        Func<IPropertyDeclarationBuilder, IPropertyDeclarationBuilder>? IPropertyBuilder = null
    )
    {
        return builder.WithProperty(identifier, x => x.AsType<T>(), IPropertyBuilder);
    }
}