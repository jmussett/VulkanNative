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

    public void GenerateCommandGroup(string commandGroupName, string folder, List<string> commands)
    {
        var compilationUnit = CSharpFactory.CompilationUnit(x => x
            .AddUsingDirective("System.Runtime.CompilerServices")
            .AddFileScopedNamespaceDeclaration("VulkanNative", x => x
                .AddClassDeclaration(commandGroupName, x =>
                {
                    x.AddModifierToken(SyntaxKind.PublicKeyword)
                     .AddModifierToken(SyntaxKind.UnsafeKeyword);

                    foreach (var commandName in commands)
                    {
                        x.AddMemberDeclaration(_commandGenerator.GenerateFunctionPointer(commandName));
                    }

                    foreach (var commandName in commands)
                    {
                        x.AddMemberDeclaration(_commandGenerator.GenerateMethod(commandName));
                    }
                })
        ));

        _documentRegistry.Documents.Add($"Generated/{folder}/{commandGroupName}.cs", compilationUnit);

    }
}
