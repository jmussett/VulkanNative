using CSharpComposer;
using Microsoft.CodeAnalysis.CSharp;
using VulkanNative.Generator.Registries;

namespace VulkanNative.Generator.SyntaxGenerators;

internal class CommandGroupGenerator
{
    private readonly DocumentRegistry _documentRegistry;
    private readonly CommandGenerator _commandGenerator;

    public CommandGroupGenerator(DocumentRegistry documentRegistry, CommandGenerator commandGenerator)
    {
        _documentRegistry = documentRegistry;
        _commandGenerator = commandGenerator;
    }

    public void GenerateCommandGroup(string commandGroupName, string folder, CommandGroupType commandGroupType, List<string> commands)
    {
        var compilationUnit = CSharpFactory.CompilationUnit(x => x
            .AddUsingDirective("VulkanNative.Abstractions")
            .AddUsingDirective("System.Runtime.CompilerServices")
            .AddFileScopedNamespaceDeclaration("VulkanNative", x => x
                .AddClassDeclaration(commandGroupName, x =>
                {
                    x.AddModifierToken(SyntaxKind.PublicKeyword)
                     .AddModifierToken(SyntaxKind.UnsafeKeyword);

                    foreach (var commandName in commands)
                    {
                        x.AddMemberDeclaration(_commandGenerator.GenerateCommandField(commandName));
                    }

                    x.AddConstructorDeclaration(commandGroupName, x =>
                    {
                        x.AddModifierToken(SyntaxKind.PublicKeyword);

                        switch (commandGroupType)
                        {
                            case CommandGroupType.Global:
                                // No handle needed
                                break;
                            case CommandGroupType.Instance:
                                x.AddParameter("instance", x => x.WithType("VkInstance"));
                                break;
                            case CommandGroupType.Device:
                                x.AddParameter("device", x => x.WithType("VkDevice"));
                                break;
                        }

                        x.AddParameter("loader", x => x.WithType("IVulkanLoader"));

                        x.WithBody(x =>
                        {
                            foreach (var commandName in commands)
                            {
                                var commandAssignment = _commandGenerator.GenerateCommandAssignment(commandName, commandGroupType);
                                x.AddExpressionStatement(x => x.FromSyntax(commandAssignment));
                            }
                        });
                    });


                    foreach (var commandName in commands)
                    {
                        x.AddMemberDeclaration(_commandGenerator.GenerateCommandMethod(commandName));
                    }
                })
        ));

        _documentRegistry.Documents.Add($"Generated/{folder}/{commandGroupName}.cs", compilationUnit);

    }
}
