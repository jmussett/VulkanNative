using CSharpComposer;
using Humanizer;
using Microsoft.CodeAnalysis.CSharp;
using VulkanNative.Generator.Registries;
using VulkanNative.Generator.VulkanRegistry;

namespace VulkanNative.Generator.SyntaxGenerators;

internal class ExtensionsLoaderGenerator
{
    private readonly DocumentRegistry _documentRegistry;
    private readonly VulkanApiRegistry _vulkanRegistry;

    public ExtensionsLoaderGenerator(DocumentRegistry documentRegistry, VulkanApiRegistry vulkanRegistry)
    {
        _documentRegistry = documentRegistry;
        _vulkanRegistry = vulkanRegistry;
    }

    public void GenerateExtensionLoader()
    {
        var compilationUnit = CSharpFactory.CompilationUnit(x => x
            .AddUsingDirective("VulkanNative.Abstractions")
            .AddFileScopedNamespaceDeclaration("VulkanNative", x => x
                .AddClassDeclaration("ExtensionLoader", x =>
                {
                    x.AddModifierToken(SyntaxKind.PublicKeyword);

                    x.AddFieldDeclaration(
                        x => x.ParseTypeName("IFunctionLoader"),
                        x => x.AddVariableDeclarator("_functionLoader"),
                        x =>
                        {
                            x.AddModifierToken(SyntaxKind.PrivateKeyword);
                            x.AddModifierToken(SyntaxKind.ReadOnlyKeyword);
                        });

                    x.AddConstructorDeclaration("ExtensionLoader", x =>
                    {
                        x.AddModifierToken(SyntaxKind.PublicKeyword);

                        x.AddParameter("functionLoader", x => x.WithType("IFunctionLoader"));

                        x.WithBody(x => x
                            .AddExpressionStatement(x => x
                                .AsAssignmentExpression(
                                    AssignmentExpressionKind.SimpleAssignmentExpression, 
                                    x => x.ParseExpression("_functionLoader"),
                                    x => x.ParseExpression("functionLoader")
                                )
                            )
                        );
                    });

                    foreach (var extension in _vulkanRegistry.Root.Extensions)
                    {
                        // Skip non-vulkan features (i.e: Vulkan sc, deprecated, obsolete, or provisional)
                        if (!extension.Supported.Split(',').Contains("vulkan") ||
                            extension.Provisional == "true" ||
                            !string.IsNullOrWhiteSpace(extension.DeprecatedBy) ||
                            !string.IsNullOrWhiteSpace(extension.ObsoletedBy)
                            )
                        {
                            continue;
                        }

                        // Skip if there isn't any commands in the extension
                        if (!extension.Requires.SelectMany(x => x.Commands).Any())
                        {
                            continue;
                        }

                        var extensionClassName = $"{extension.Name.ToLowerInvariant().Pascalize()}Extension";

                        x.AddMethodDeclaration(
                            x => x.AsIdentifierName(extensionClassName),
                            $"Load{extensionClassName}", 
                            x =>
                            {
                                x.AddModifierToken(SyntaxKind.PublicKeyword);

                                switch (extension.Type)
                                {
                                    case "instance":
                                        x.AddParameter("instance", x => x.WithType("VkInstance"));
                                        break;  
                                    case "device":
                                        x.AddParameter("device", x => x.WithType("VkDevice"));
                                        break;
                                    default:
                                        throw new InvalidOperationException($"Unknown extension type '{extension.Type}'");
                                }

                                x.WithBody(x => x
                                    .AddReturnStatement(x => x
                                        .WithExpression(x => x
                                            .AsObjectCreationExpression(
                                                x => x.AsIdentifierName(extensionClassName),
                                                x =>
                                                {
                                                    switch (extension.Type)
                                                    {
                                                        case "instance":
                                                            x.AddArgument("instance");
                                                            break;
                                                        case "device":
                                                            x.AddArgument("device");
                                                            break;
                                                        default:
                                                            throw new InvalidOperationException($"Unknown extension type '{extension.Type}'");
                                                    }

                                                    x.AddArgument("_functionLoader");
                                                }
                                            )
                                        )
                                    )
                                );
                            }
                        );
                    }
                })
            ));

        _documentRegistry.Documents.Add($"Generated/ExtensionLoader.cs", compilationUnit);
    }
}
