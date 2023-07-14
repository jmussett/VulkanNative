using Humanizer;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Formatting;
using Microsoft.CodeAnalysis.MSBuild;
using SyntaxBuilder.Builders;
using SyntaxBuilder.Generator.Models;
using SyntaxBuilder.Types;
using System.IO;
using System.Security.AccessControl;
using System.Xaml.Permissions;
using System.Xml.Serialization;

var registryUrl = "https://raw.githubusercontent.com/dotnet/roslyn/main/src/Compilers/CSharp/Portable/Syntax/Syntax.xml";
using var httpClient = new HttpClient();

var registryXml = await httpClient.GetStringAsync(registryUrl);

var serializer = new XmlSerializer(typeof(Tree));
using var reader = new StringReader(registryXml);
var tree = (Tree) serializer.Deserialize(reader)!;

var workspace = MSBuildWorkspace.Create();

var project = await workspace.OpenProjectAsync("..\\..\\..\\..\\SyntaxBuilder.Gen\\SyntaxBuilder.Gen.csproj");

var documentRegistry = new Dictionary<string, CompilationUnitSyntax>();

foreach (var type in tree.Types)
{
    if (!IsValidNode(type.Name))
    {
        continue;
    }

    var builderName = $"{type.Name![..^"Syntax".Length]}Builder";

    var compilationUnit = CompilationUnitBuilder.CreateSyntax(x => x
        .WithUsing("Microsoft.CodeAnalysis.CSharp.Syntax")
        .WithFileScopedNamespace("SyntaxBuilder.Builder", x =>
        {
            if (type is AbstractNode)
            {
                x = x.WithInterface($"I{builderName}", x =>
                {
                    x = x.WithAccessModifier(TypeAccessModifier.Public);

                    // I don't think we need this as we don't want to polute base type casting methods with builder methods

                    //x = x.WithBaseType(x =>
                    //{
                    //    x.AsGeneric($"I{builderName}", x => x.WithTypeArgument(x => x.AsType($"I{builderName}")));

                    //    return x;
                    //});

                    var derivedTypes = tree.Types.Where(x => x.Base == type.Name);

                    foreach (var derivedType in derivedTypes)
                    {
                        x = x.WithMethod(
                            $"As{derivedType.Name![..^"Syntax".Length]}",
                            x => x.AsVoid(),
                            x => x // TODO : make optional for interfaces?
                        );
                    }

                    return x;
                });
            }

            return x
                .WithInterface($"I{builderName}", x =>
                {
                    x = x.WithAccessModifier(TypeAccessModifier.Public);

                    if (type is AbstractNode)
                    {
                        x = x.WithTypeParameter("TBuilder");

                        if (IsValidNode(type.Base))
                        {
                            x = x.WithBaseType(x =>
                            {
                                x.AsGeneric($"I{type.Base![..^"Syntax".Length]}Builder", x => x.WithTypeArgument(x => x.AsType("TBuilder")));

                                return x;
                            });
                        }
                    }
                    else
                    {
                        if (IsValidNode(type.Base))
                        {
                            return x.WithBaseType(x =>
                            {
                                x.AsGeneric($"I{type.Base![..^"Syntax".Length]}Builder", x => x.WithTypeArgument(x => x.AsType($"I{builderName}")));

                                return x;
                            });
                        }
                    }

                    return x;
                })
                .WithClass(builderName, x =>
                {
                    x = x.WithAccessModifier(TypeAccessModifier.Public)
                        .WithBaseType(x => x.AsType($"I{builderName}")); // TODO: Extension

                    if (IsValidNode(type.Base))
                    {
                        x = x.WithField("_builder", x => x.AsType($"{type.Base![..^"Syntax".Length]}Builder"), x => x
                            .WithAccessModifier(MemberAccessModifier.Private)
                        );

                        x = x.WithProperty("Syntax", x => x.AsType(type.Name), x => x
                            .WithAccessModifier(MemberAccessModifier.Public)
                            .WithGetter(x => x.WithExpressionBody(x => x.ParseExpression($"({type.Name}) _builder.Syntax")))
                            .WithSetter(x => x.WithExpressionBody(x => x.ParseExpression("_builder.Syntax = value")))
                        );

                        x = x.WithConstructor(x => x
                            .WithAccessModifier(MemberAccessModifier.Public)
                            .WithParameter("syntax", x => x.AsType(type.Name))
                            .WithBody(x => x
                                .WithExpression(x => x
                                    .AsAssignment(
                                        x => x.AsName("_builder"),
                                        AssignmentType.Equal,
                                        x => x.AsNew(
                                            x => x.AsType($"{type.Base![..^"Syntax".Length]}Builder"),
                                            x => x.WithArgument(x => x.AsName("syntax"))
                                        )
                                    )
                                )
                             )
                        );
                    }
                    else
                    {
                        x = x.WithProperty("Syntax", x => x.AsType(type.Name), x => x
                            .WithAccessModifier(MemberAccessModifier.Public)
                            .WithGetter()
                            .WithSetter()
                        );

                        x = x.WithConstructor(x => x
                            .WithAccessModifier(MemberAccessModifier.Public)
                            .WithParameter("syntax", x => x.AsType(type.Name))
                            .WithBody(x => x
                                .WithExpression(x => x
                                    .AsAssignment(x => x.AsName("Syntax"), AssignmentType.Equal, x => x.AsName("syntax"))
                                )
                             )
                        );
                    }

                    // TODO: Custom CreateSyntax for base types
                    //x = x.WithMethod(
                    //    "CreateSyntax",
                    //    x => x.AsType(type.Name),
                    //    x => x.WithAccessModifier(MemberAccessModifier.Public)
                    //        .WithStaticModifier()
                    //        .WithBody(x =>
                    //        {
                    //            return x;
                    //        })
                    //);

                    if (type is AbstractNode)
                    {
                        var derivedTypes = tree.Types.Where(x => x.Base == type.Name);

                        foreach (var derivedType in derivedTypes)
                        {
                            x = WithAbstractMethod(x, derivedType);
                        }
                    }

                    x = WithChildren(x, tree, builderName, type.Children);

                    return x;
                });
        })
    );

    documentRegistry.Add($"Builders/{builderName}.cs", compilationUnit);
}


foreach (var documentEntry in documentRegistry)
{
    var documentName = documentEntry.Key;
    var compilationUnit = documentEntry.Value;

    //compilationUnit = SimplifierAnnotator.Annotate(compilationUnit);

    var document = project.AddDocument(documentName, compilationUnit);

    var formattedDocument = await Formatter.FormatAsync(document);
    var formattedText = await formattedDocument.GetTextAsync();

    var updatedDocument = formattedDocument.Project
        .GetDocument(formattedDocument.Id)!
        .WithText(formattedText);

    //var simplifiedDocument = await Simplifier.ReduceAsync(updatedDocument);

    project = updatedDocument.Project;
}

workspace.TryApplyChanges(project.Solution);

static IClassDeclarationBuilder WithFields(IClassDeclarationBuilder builder, Tree tree, string builderName, IEnumerable<Field> fields)
{
    foreach (var field in fields)
    {
        builder = WithField(builder, builderName, field);

        if (IsAnyList(field.Type))
        {
            builder = AddListType(builder, builderName, field);
        }
        else
        {
            var referenceTypeNode = tree.Types.FirstOrDefault(x => x.Name == field.Type);

            if (referenceTypeNode is not null)
            {
                foreach (var referencedNodeField in referenceTypeNode.Children.OfType<Field>())
                {
                    if (IsAnyList(referencedNodeField.Type))
                    {
                        builder = AddReferencedListType(builder, builderName, field, referencedNodeField);
                    }
                }
            }
        }
    }

    return builder;
}

static IClassDeclarationBuilder WithChildren(IClassDeclarationBuilder x, Tree tree, string builderName, List<TreeTypeChild> children)
{
    // TODO: sequence

    foreach (var choice in children.OfType<Choice>())
    {
        x = WithChildren(x, tree, builderName, choice.Children);
    }

    return WithFields(x, tree, builderName, children.OfType<Field>());
}

static IClassDeclarationBuilder AddListType(IClassDeclarationBuilder builder, string builderName, Field field)
{
    return builder.WithMethod(
        $"Add{GetSingularName(field.Name)}",
        x => x.AsType($"I{builderName}"),
        x => x.WithAccessModifier(MemberAccessModifier.Public)
            .WithBody(x =>
            {
                x = x.WithReturnStatement(x => x.ParseExpression("this"));
                return x;
            })
        );
}

static IClassDeclarationBuilder AddReferencedListType(IClassDeclarationBuilder builder, string builderName, Field field, Field referencedNodeField)
{
    return builder.WithMethod(
        GenerateAddMethodName(field, referencedNodeField),
        x => x.AsType($"I{builderName}"),
        x => x.WithAccessModifier(MemberAccessModifier.Public)
            .WithBody(x =>
            {
                x = x.WithReturnStatement(x => x.ParseExpression("this"));
                return x;
            })
        );
}

static IClassDeclarationBuilder WithField(IClassDeclarationBuilder builder, string builderName, Field field)
{
    return builder.WithMethod(
        $"With{field.Name}",
        x => x.AsType($"I{builderName}"),
        x => x.WithAccessModifier(MemberAccessModifier.Public)
            .WithBody(x =>
            {
                x = x.WithReturnStatement(x => x.ParseExpression("this"));
                return x;
            })
    );
}

static IClassDeclarationBuilder WithAbstractMethod(IClassDeclarationBuilder builder, TreeType? derivedType)
{
    return builder.WithMethod(
        $"As{derivedType.Name![..^"Syntax".Length]}",
        x => x.AsVoid(),
        x => x.WithAccessModifier(MemberAccessModifier.Public)
            .WithBody(x =>
            {
                return x;
            })
    );
}

static string GenerateAddMethodName(Field parentField, Field referencedField)
{
    string parentFieldName = GetSingularName(parentField.Name);
    string referencedFieldName = GetSingularName(referencedField.Name);

    string suffix = parentFieldName;

    if (!parentFieldName.EndsWith(referencedFieldName))
    {
        suffix += referencedFieldName;
    }

    return "Add" + suffix;
}

static string LongestCommonPrefix(string s1, string s2)
{
    int commonLength = 0;
    while (commonLength < s1.Length && commonLength < s2.Length && s1[commonLength] == s2[commonLength])
    {
        commonLength++;
    }

    return s1.Substring(0, commonLength);
}

static string GetSingularName(string fieldName)
{
    fieldName = fieldName.Singularize();

    var suffix = "List";

    if (string.IsNullOrEmpty(fieldName) || string.IsNullOrEmpty(suffix))
    {
        return fieldName;
    }

    if (fieldName.EndsWith(suffix))
    {
        return fieldName[..^suffix.Length];
    }

    return fieldName;
}

static bool IsValidNode(string? nodeName)
{
    return nodeName is not null
        && nodeName != "SyntaxNode"
        && nodeName != "CSharpSyntaxNode"
        && nodeName != "SyntaxToken"
        && nodeName != "StructuredTriviaSyntax";
}

static bool IsSeparatedNodeList(string typeName)
{
    return typeName.StartsWith("SeparatedSyntaxList<", StringComparison.Ordinal);
}

static bool IsNodeList(string typeName)
{
    return typeName.StartsWith("SyntaxList<", StringComparison.Ordinal);
}
static bool IsAnyNodeList(string typeName)
{
    return IsNodeList(typeName) || IsSeparatedNodeList(typeName);
}

static bool IsAnyList(string typeName)
{
    return IsNodeList(typeName) || IsSeparatedNodeList(typeName) || typeName == "SyntaxNodeOrTokenList";
}

static bool IsRoot(Node n)
{
    return n.Root != null && string.Compare(n.Root, "true", true) == 0;
}

static bool IsTrue(string val)
    => val != null && string.Compare(val, "true", true) == 0;

static bool IsOptional(Field f)
    => IsTrue(f.Optional);

static bool IsOverride(Field f)
    => IsTrue(f.Override);

static bool IsNew(Field f)
    => IsTrue(f.New);

