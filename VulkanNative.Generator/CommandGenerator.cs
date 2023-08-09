using CSharpComposer;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using VulkanNative.Generator.Registry;

namespace VulkanNative.Generator;

internal class CommandGenerator
{
    private readonly TypeLocator _typeLocator;
    private readonly IReadOnlyDictionary<string, VkCommand> _commandLookup;

    public CommandGenerator(VkRegistry vkRegistry, TypeLocator typeLocator)
    {
        _typeLocator = typeLocator;
        _commandLookup = vkRegistry.CreateCommandLookup();
    }

    public FieldDeclarationSyntax GenerateCommand(string commandName)
    {
        if (!_commandLookup.TryGetValue(commandName, out var commandDefinition))
        {
            throw new InvalidOperationException($"Unable to find command '{commandName}'");
        }

        return CSharpFactory.FieldDeclaration(
            x => x.AsFunctionPointerType(x =>
            {
                x.WithCallingConvention(
                    FunctionPointerCallingConventionManagedOrUnmanagedKeyword.UnmanagedKeyword,
                    x => x.AddFunctionPointerUnmanagedCallingConvention("Cdecl")
                );

                foreach (var param in commandDefinition.Params)
                {
                    var typeDef = _typeLocator.LookupType(param.Type, param.PostTypeText);

                    if (typeDef.Arguments.Length == 0)
                    {
                        x.AddFunctionPointerParameter(
                            x => x.FromSyntax(typeDef.Syntax)
                        );
                    }
                    else
                    {
                        // We could use an inline array type, but we'd have to generate this on top of the function pointer.
                        // So leave it as a pointer for now.
                        x.AddFunctionPointerParameter(
                            x => x.AsPointerType(x => x.FromSyntax(typeDef.Syntax))
                        );
                    }
                }

                x.AddFunctionPointerParameter(
                    x => x.FromSyntax(_typeLocator.LookupType(commandDefinition.Proto.Type))
                );
            }),
            x => x.AddVariableDeclarator(commandName),
            x => x.AddModifierToken(SyntaxKind.PublicKeyword)
        );
    }
}
