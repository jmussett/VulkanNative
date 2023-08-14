using CSharpComposer;
using Microsoft.CodeAnalysis.CSharp;
using VulkanNative.Generator.Registries;
using VulkanNative.Generator.Registry;
using VulkanNative.Generator.VulkanRegistry;

namespace VulkanNative.Generator.SyntaxGenerators;

internal class ApiConstantsGenerator
{
    private readonly VulkanApiRegistry _vulkanRegistry;
    private readonly DocumentRegistry _documentRegistry;
    private readonly TypeLocator _typeLocator;

    public ApiConstantsGenerator(VulkanApiRegistry vulkanRegistry, DocumentRegistry documentRegistry, TypeLocator typeLocator)
    {
        _vulkanRegistry = vulkanRegistry;
        _documentRegistry = documentRegistry;
        _typeLocator = typeLocator;
    }

    public void GenerateApiConstants()
    {
        var compilationUnit = CSharpFactory.CompilationUnit(x => x
            .AddFileScopedNamespaceDeclaration("VulkanNative", x => x
                .AddClassDeclaration("VulkanApiConstants", x =>
                {
                    x.AddModifierToken(SyntaxKind.PublicKeyword);
                    x.AddModifierToken(SyntaxKind.StaticKeyword);

                    var constantEnumeration = _vulkanRegistry.Root.Enums.First(x => x.Name == "API Constants");

                    foreach (VkEnum constant in constantEnumeration.Enums)
                    {
                        if (!string.IsNullOrWhiteSpace(constant.Alias))
                        {
                            continue;
                        }

                        var constantType = _typeLocator.LookupType(constant.Type);

                        x.AddFieldDeclaration(
                            x => x.FromSyntax(constantType),
                            x => x.AddVariableDeclarator(constant.Name, x => x.WithInitializer(constant.Value!.Replace("LL", "L"))),
                            x => x
                                .AddModifierToken(SyntaxKind.PublicKeyword)
                                .AddModifierToken(SyntaxKind.ConstKeyword)
                        );
                    }
                })
            )
        );

        _documentRegistry.Documents.Add("VulkanApiConstants.cs", compilationUnit);
    }
}
