using CSharpComposer;
using Humanizer;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Operations;
using VulkanNative.Generator.Registry;
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

    public FieldDeclarationSyntax GenerateCommandField(string commandName)
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

        var functionPointerType = CreateFunctionPointer(commandDefinition);

        return CSharpFactory.FieldDeclaration(
            x => x.FromSyntax(functionPointerType),
            x => x.AddVariableDeclarator($"_{commandName}"),
            x => x.AddModifierToken(SyntaxKind.PrivateKeyword)
        );
    }

    public AssignmentExpressionSyntax GenerateCommandAssignment(string commandName, CommandGroupType commandGroupType)
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

        var functionPointerType = CreateFunctionPointer(commandDefinition);

        var getProcAddrFunction = commandGroupType switch
        {
            CommandGroupType.Global => "GetProcAddr",
            CommandGroupType.Instance => "GetInstanceProcAddr",
            CommandGroupType.Device => "GetDeviceProcAddr",
            _ => throw new InvalidOperationException($"Unknown command group type '{commandGroupType}'")
        };

        var getProcAddrCall = CSharpFactory.InvocationExpression(x => x
            .AsMemberAccessExpression(
                MemberAccessExpressionKind.SimpleMemberAccessExpression,
                x => x.AsIdentifierName("loader"),
                x => x.AsIdentifierName(getProcAddrFunction)
            ),
            x =>
            {
                switch (commandGroupType)
                {
                    case CommandGroupType.Global:
                        break;
                    case CommandGroupType.Instance:
                        x.AddArgument("instance");
                        break;
                    case CommandGroupType.Device:
                        x.AddArgument("device");
                        break;
                }

                x.AddArgument($"\"{commandName}\"");
            }
        );

        return CSharpFactory.AssignmentExpression(
            AssignmentExpressionKind.SimpleAssignmentExpression,
            x => x.AsIdentifierName($"_{commandName}"),
            x => x.AsCastExpression(x => x.FromSyntax(functionPointerType), x => x.FromSyntax(getProcAddrCall))
        );
    }

    public MethodDeclarationSyntax GenerateCommandMethod(string commandName)
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

        var returnType = _typeLocator.LookupType(commandDefinition.Proto.Type);

        var parameters = commandDefinition.Params
            .Where(x => x.Api is null || x.Api.Split(",").Contains("vulkan"))
            .ToList();

        return CSharpFactory.MethodDeclaration(
            x => x.FromSyntax(returnType),
            commandName.Pascalize(),
            x =>
            {
                x.AddModifierToken(SyntaxKind.PublicKeyword);
                x.AddAttribute("MethodImpl(MethodImplOptions.AggressiveInlining)");

                foreach(var parameter in parameters)
                {
                    TypeSyntax typeSyntax;
                    var typeDef = _typeLocator.LookupType(parameter.Type, parameter.PostTypeText);

                    if (typeDef.Arguments.Length == 0)
                    {
                        typeSyntax = typeDef.Syntax;
                    }
                    else
                    {
                        // We could use an inline array type, but we'd have to generate this on top of the function pointer.
                        // So leave it as a pointer for now.
                        typeSyntax = CSharpFactory.PointerType(x => x.FromSyntax(typeDef.Syntax));
                    }

                    x.AddParameter(VariableNameSanitizer.Sanitize(parameter.Name), x => x.WithType(typeSyntax));
                }

                x.WithBody(x =>
                {
                    // TODO: Do null check against function pointer

                    var methodCallExpression = CSharpFactory.Expression(x => x
                        .AsInvocationExpression(
                            x => x.AsIdentifierName($"_{commandName}"),
                            x =>
                            {
                                foreach (var parameter in parameters)
                                {
                                    x.AddArgument(x => x
                                        .AsIdentifierName(VariableNameSanitizer.Sanitize(parameter.Name))
                                    );
                                }
                            }
                        )
                    );

                    if (commandDefinition.Proto.Type == "void")
                    {
                        x.AddExpressionStatement(x => x.FromSyntax(methodCallExpression));
                    }
                    else
                    {
                        x.AddReturnStatement(x => x.WithExpression(methodCallExpression));
                    }


                    //x.AddStatement($"return _{commandName}();");
                });
            }
        );
    }

    private FunctionPointerTypeSyntax CreateFunctionPointer(VkCommand commandDefinition)
    {
        return CSharpFactory.FunctionPointerType(x =>
        {
            x.WithCallingConvention(
                FunctionPointerCallingConventionManagedOrUnmanagedKeyword.UnmanagedKeyword,
                x => x.AddFunctionPointerUnmanagedCallingConvention("Cdecl")
            );

            var parameters = commandDefinition.Params
                .Where(x => x.Api is null || x.Api.Split(",").Contains("vulkan"))
                .ToList();

            foreach (var param in parameters)
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
        });
    }
}
