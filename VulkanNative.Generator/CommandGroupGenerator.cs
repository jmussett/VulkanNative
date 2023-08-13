﻿using CSharpComposer;
using Microsoft.CodeAnalysis.CSharp;
using VulkanNative.Generator.Registries;
using VulkanNative.Generator.Registry;

namespace VulkanNative.Generator;

internal class CommandGroupGenerator
{
    private readonly VkRegistry _vkRegistry;
    private readonly DocumentRegistry _documentRegistry;
    private readonly CommandGenerator _commandGenerator;
    private readonly TypeLocator _typeLocator;
    private readonly EnumRegistry _enumRegistry;

    private readonly IReadOnlyDictionary<string, VkCommand> _commandLookup;
    private readonly IReadOnlyDictionary<string, VkType> _handleLookup;

    public CommandGroupGenerator(VkRegistry vkRegistry, DocumentRegistry documentRegistry, CommandGenerator commandGenerator, TypeLocator typeLocator, EnumRegistry enumRegistry)
    {
        _vkRegistry = vkRegistry;
        _documentRegistry = documentRegistry;
        _commandGenerator = commandGenerator;
        _typeLocator = typeLocator;
        _enumRegistry = enumRegistry;
        _commandLookup = vkRegistry.CreateCommandLookup();
        _handleLookup = vkRegistry.CreateHandleLookup();
    }

    public void GenerateCommandGroups()
    {
        var globalCommands = new List<string>();
        var instanceCommands = new List<string>();
        var deviceCommands = new List<string>();

        foreach (var feature in _vkRegistry.Feature)
        {
            // Skip non-vulkan features (i.e: Vulkan sc only)
            if (!feature.Api.Split(',').Contains("vulkan"))
            {
                continue;
            }

            foreach(var requires in feature.Requires)
            {
                foreach(var type in requires.Types)
                {
                    var vkType = _vkRegistry.Types.FirstOrDefault(x => x.Name == type.NameAttribute)
                        ?? _vkRegistry.Types.FirstOrDefault(x => x.NameAttribute == type.NameAttribute)
                        ?? throw new InvalidOperationException($"Unable to find type '{type.NameAttribute}'");

                    if (vkType.Category != "include" && vkType.Category != "define")
                    {
                        // Will do a type lookup and register the type if it hasn't been registered already
                        _ = _typeLocator.LookupType(type.NameAttribute);
                    }
                }

                foreach (var command in requires.Commands)
                {
                    if (!_commandLookup.TryGetValue(command.Name, out var commandDefinition))
                    {
                        throw new InvalidOperationException($"Unable to find command definition '{command.Name}'");
                    }

                    var functionName = commandDefinition.Proto.Name;
                    var firstParamType = commandDefinition.Params.FirstOrDefault()?.Type;

                    if (functionName == "vkGetDeviceProcAddr" || functionName == "vkGetInstanceProcAddr")
                    {
                        continue;
                    }

                    if (firstParamType is not null && IsHandleInheritsFrom(firstParamType, "VkDevice"))
                    {
                        deviceCommands.Add(command.Name);
                    }
                    else if (firstParamType is not null && IsHandleInheritsFrom(firstParamType, "VkInstance"))
                    {
                        instanceCommands.Add(command.Name);
                    }
                    else
                    {
                        globalCommands.Add(command.Name);
                    }
                }

                foreach(var enumMember in requires.Enums)
                {
                    if (enumMember.Extends is null)
                    {
                        continue;
                    }

                    _enumRegistry.Enums.TryAdd(enumMember.Extends, new EnumDefinition());

                    _enumRegistry.Enums[enumMember.Extends].Members.Add(enumMember);
                }
            }
        }

        var compilationUnit = CSharpFactory.CompilationUnit(x => x
            .AddFileScopedNamespaceDeclaration("VulkanNative", x => x
                .AddClassDeclaration("VkGlobalCommands", x =>
                {
                    x.AddModifierToken(SyntaxKind.PublicKeyword)
                     .AddModifierToken(SyntaxKind.UnsafeKeyword);

                    foreach (var commandName in globalCommands)
                    {
                        x.AddMemberDeclaration(_commandGenerator.GenerateCommand(commandName));
                    }
                })
            ));

        _documentRegistry.Documents.Add("Commands/VkGlobalCommands.cs", compilationUnit);

        compilationUnit = CSharpFactory.CompilationUnit(x => x
            .AddFileScopedNamespaceDeclaration("VulkanNative", x => x
                .AddClassDeclaration("VkInstanceCommands", x =>
                {
                    x
                        .AddModifierToken(SyntaxKind.PublicKeyword)
                        .AddModifierToken(SyntaxKind.UnsafeKeyword);

                    foreach (var commandName in instanceCommands)
                    {
                        x.AddMemberDeclaration(_commandGenerator.GenerateCommand(commandName));
                    }
                })
            ));

        _documentRegistry.Documents.Add("Commands/VkInstanceCommands.cs", compilationUnit);

        compilationUnit = CSharpFactory.CompilationUnit(x => x
            .AddFileScopedNamespaceDeclaration("VulkanNative", x => x
                .AddClassDeclaration("VkDeviceCommands", x =>
                {
                    x = x
                        .AddModifierToken(SyntaxKind.PublicKeyword)
                        .AddModifierToken(SyntaxKind.UnsafeKeyword);

                    foreach (var commandName in deviceCommands)
                    {
                        x.AddMemberDeclaration(_commandGenerator.GenerateCommand(commandName));
                    }
                })
            ));

        _documentRegistry.Documents.Add("Commands/VkDeviceCommands.cs", compilationUnit);
    }

    private bool IsHandleInheritsFrom(string handleType, string parentType)
    {
        var current = handleType;

        while (current is not null && _handleLookup.TryGetValue(current, out var handle))
        {
            if (handle.Name == parentType || handle.Parent == parentType)
                return true;

            current = handle.Parent;
        }

        return false;
    }
}