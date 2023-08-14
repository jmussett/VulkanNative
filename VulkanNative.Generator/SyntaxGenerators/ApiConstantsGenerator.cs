using CSharpComposer;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VulkanNative.Generator.Registries;
using VulkanNative.Generator.Registry;

namespace VulkanNative.Generator;

internal class ApiConstantsGenerator
{
    private readonly VkRegistry _vkRegistry;
    private readonly DocumentRegistry _documentRegistry;
    private readonly TypeLocator _typeLocator;

    public ApiConstantsGenerator(VkRegistry vkRegistry, DocumentRegistry documentRegistry, TypeLocator typeLocator)
    {
        _vkRegistry = vkRegistry;
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

                    var constantEnumeration = _vkRegistry.Enums.First(x => x.Name == "API Constants");

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
