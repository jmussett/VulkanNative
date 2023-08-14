using CSharpComposer;
using Humanizer;
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

    public FieldDeclarationSyntax GenerateFunctionPointer(string commandName)
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

        var parameters = commandDefinition.Params
            .Where(x => x.Api is null || x.Api.Split(",").Contains("vulkan"))
            .ToList();

        return CSharpFactory.FieldDeclaration(
            x => x.AsFunctionPointerType(x =>
            {
                x.WithCallingConvention(
                    FunctionPointerCallingConventionManagedOrUnmanagedKeyword.UnmanagedKeyword,
                    x => x.AddFunctionPointerUnmanagedCallingConvention("Cdecl")
                );

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
            }),
            x => x.AddVariableDeclarator($"_{commandName}"),
            x => x.AddModifierToken(SyntaxKind.PrivateKeyword)
        );
    }

    public MethodDeclarationSyntax GenerateMethod(string commandName)
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

    //[MethodImpl(MethodImplOptions.AggressiveInlining)]
    //public VkResult VkGetPhysicalDeviceToolProperties(VkPhysicalDevice physicalDevice, uint* pToolCount, VkPhysicalDeviceToolProperties* pToolProperties)
    //{
    //    return vkGetPhysicalDeviceToolProperties(physicalDevice, pToolCount, pToolProperties);
    //}
}
