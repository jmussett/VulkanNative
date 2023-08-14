using CSharpComposer;
using Humanizer;
using Microsoft.CodeAnalysis.CSharp;
using VulkanNative.Generator.Registries;
using VulkanNative.Generator.Registry;

namespace VulkanNative.Generator.SyntaxGenerators;

internal class ExtensionGenerator
{
    private readonly VkRegistry _vkRegistry;
    private readonly CommandGroupGenerator _commandGroupGenerator;
    private readonly TypeLocator _typeLocator;
    private readonly EnumRegistry _enumRegistry;

    private readonly IReadOnlyDictionary<string, VkCommand> _commandLookup;
    private readonly IReadOnlyDictionary<string, VkType> _handleLookup;

    public ExtensionGenerator(VkRegistry vkRegistry, CommandGroupGenerator commandGroupGenerator, TypeLocator typeLocator, EnumRegistry enumRegistry)
    {
        _vkRegistry = vkRegistry;
        _commandGroupGenerator = commandGroupGenerator;
        _typeLocator = typeLocator;
        _enumRegistry = enumRegistry;

        _commandLookup = vkRegistry.CreateCommandLookup();
        _handleLookup = vkRegistry.CreateHandleLookup();
    }

    public void GenerateExtensions()
    {
        foreach (var extension in _vkRegistry.Extensions)
        {
            // Skip non-vulkan features (i.e: Vulkan sc, deprecated, obsolete, or provisional)
            if (!extension.Supported.Split(',').Contains("vulkan") ||
                extension.Provisional == "true" ||
                //!string.IsNullOrWhiteSpace(extension.PromotedTo) ||
                !string.IsNullOrWhiteSpace(extension.DeprecatedBy) ||
                !string.IsNullOrWhiteSpace(extension.ObsoletedBy)
                )
            {
                continue;
            }

            List<string> extensionCommands = new();

            foreach (var requires in extension.Requires)
            {
                foreach (var type in requires.Types)
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

                foreach (var enumMember in requires.Enums)
                {
                    if (enumMember.Extends is null)
                    {
                        continue;
                    }

                    _enumRegistry.Enums.TryAdd(enumMember.Extends, new EnumDefinition());

                    _enumRegistry.Enums[enumMember.Extends].ExtensionNumber = int.Parse(extension.Number!);
                    _enumRegistry.Enums[enumMember.Extends].Members[enumMember.Name] = enumMember;
                }


                extensionCommands.AddRange(requires.Commands.Select(x => x.Name));
            }

            if (extensionCommands.Count > 0)
            {
                var extensionClassName = $"{extension.Name.ToLowerInvariant().Pascalize()}Extension";

                _commandGroupGenerator.GenerateCommandGroup(extensionClassName, "Extensions", extensionCommands);
            }
        }
    }
}