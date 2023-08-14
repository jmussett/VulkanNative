using CSharpComposer;
using Humanizer;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using VulkanNative.Generator.Registries;
using VulkanNative.Generator.Registry;

namespace VulkanNative.Generator.Generators;

internal class StructTypeGenerator : ITypeGenerator
{
    private readonly DocumentRegistry _documentRegistry;
    private readonly TypeLocator _typeLocator;

    public StructTypeGenerator(DocumentRegistry documentRegistry, TypeLocator locator)
    {
        _documentRegistry = documentRegistry;
        _typeLocator = locator;
    }

    public TypeSyntax GenerateType(string typeName, VkType structDefinition)
    {
        var compilationUnit = CSharpFactory.CompilationUnit(x => x
            .AddUsingDirective("System.Runtime.InteropServices")
            .AddFileScopedNamespaceDeclaration("VulkanNative", x =>
                x.AddStructDeclaration(typeName, x => {
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

                        TypeDefinition typeDef;

                        // Safety check to prevent circular references.
                        if (fieldDefinition.Type == typeName)
                        {
                            typeDef = _typeLocator.LookupType(fieldDefinition.Type, fieldDefinition.PostTypeText, () =>
                            {
                                var syntax = CSharpFactory.Type(typeName);

                                return new TypeDefinition(syntax);
                            });
                        }
                        else
                        {
                            typeDef = _typeLocator.LookupType(fieldDefinition.Type, fieldDefinition.PostTypeText);
                        }

                        x.AddFieldDeclaration(
                            x => x.FromSyntax(typeDef.Syntax),
                            x => x.AddVariableDeclarator(fieldDefinition.Name.Pascalize(), x =>
                            {
                                foreach(var argument in typeDef.Arguments)
                                {
                                      x.AddArgument(x => x.FromSyntax(argument));
                                }
                            }),
                            x => {
                                x.AddModifierToken(SyntaxKind.PublicKeyword);

                                foreach (var modifier in typeDef.Modifiers)
                                {
                                    x = x.AddModifierToken(modifier);
                                }
                            }
                        );
                    }
                })
            )
        );

        _documentRegistry.Documents.Add($"Generated/Structs/{typeName}.cs", compilationUnit);

        return CSharpFactory.Type(typeName);
    }
}
