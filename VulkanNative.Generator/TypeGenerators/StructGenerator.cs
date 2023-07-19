using CSharpComposer;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using VulkanNative.Generator.Registries;
using VulkanNative.Generator.Registry;

namespace VulkanNative.Generator.Generators;

internal class StructGenerator : ITypeGenerator
{
    private readonly DocumentRegistry _documentRegistry;
    private readonly TypeLocator _typeLocator;

    public StructGenerator(DocumentRegistry documentRegistry, TypeLocator locator)
    {
        _documentRegistry = documentRegistry;
        _typeLocator = locator;
    }

    public TypeSyntax GenerateType(VkType structDefinition)
    {
        var structName = structDefinition.NameAttribute;

        var compilationUnit = CSharpFactory.CompilationUnit(x => x
            .AddUsingDirective("System.Runtime.InteropServices")
            .AddFileScopedNamespaceDeclaration("VulkanNative", x =>
                x.AddStructDeclaration(structName, x => {
                    x = x
                        .AddModifierToken(SyntaxKind.PublicKeyword)
                        .AddModifierToken(SyntaxKind.UnsafeKeyword)
                        .AddAttribute("StructLayout", x => x.AddAttributeArgument("LayoutKind.Sequential"));

                    // returnedonly ?? -> readonly
                    // structextends ?? indicates that struct extends the "structextends" struct. Maybe not necessary for initial code gen.

                    foreach (var fieldDefinition in structDefinition.Members)
                    {
                        // platform specific?
                        // optional?
                        // array?

                        if (!string.IsNullOrEmpty(fieldDefinition.Api) && fieldDefinition.Api != "vulkan")
                        {
                            // Skip when the field is not part of the standard vulkan api (i.e: vulkansc)
                            continue;
                        }

                        x = x.AddFieldDeclaration(
                            x => x.FromSyntax(_typeLocator.LookupType(fieldDefinition.Type, fieldDefinition.PostTypeText)),
                            x => x.AddVariableDeclarator(fieldDefinition.Name),
                            x => x.AddModifierToken(SyntaxKind.PublicKeyword)
                        );
                    }
                })
            )
        );

        _documentRegistry.Documents.Add($"Structs/{structName}.cs", compilationUnit);

        return CSharpFactory.Type(structName);
    }
}
