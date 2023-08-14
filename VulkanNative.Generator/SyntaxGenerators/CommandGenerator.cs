using CSharpComposer;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using VulkanNative.Generator.VulkanRegistry;

namespace VulkanNative.Generator.SyntaxGenerators;

internal class CommandGenerator
{
    private readonly VulkanApiRegistry _vulkanRegistry;
    private readonly TypeLocator _typeLocator;

    public CommandGenerator(VulkanApiRegistry vulkanRegistry, TypeLocator typeLocator)
    {
        _vulkanRegistry = vulkanRegistry;
        _typeLocator = typeLocator;
    }

    public FieldDeclarationSyntax GenerateCommand(string commandName)
    {
        // TODO: Cache?
        var aliasMap = _vulkanRegistry.Root.Commands
            .Where(x => x.Api is null || x.Api == "vulkan")
            .Where(x => x.Alias is not null)
            .ToDictionary(x => x.Name, x => x.Alias!);

        if (aliasMap.TryGetValue(commandName, out var aliasName))
        {
            commandName = aliasName;
        }

        var commandLookup = _vulkanRegistry.Root.CreateCommandLookup();

        if (!commandLookup.TryGetValue(commandName, out var commandDefinition))
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
