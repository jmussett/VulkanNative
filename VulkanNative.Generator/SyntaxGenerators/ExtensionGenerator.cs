using Humanizer;
using VulkanNative.Generator.Registries;
using VulkanNative.Generator.Registry;
using VulkanNative.Generator.VulkanRegistry;

namespace VulkanNative.Generator.SyntaxGenerators;

internal class ExtensionGenerator
{
    private readonly VulkanApiRegistry _vulkanRegistry;
    private readonly CommandGroupGenerator _commandGroupGenerator;
    private readonly TypeLocator _typeLocator;
    private readonly EnumRegistry _enumRegistry;

    public ExtensionGenerator(VulkanApiRegistry vulkanRegistry, CommandGroupGenerator commandGroupGenerator, TypeLocator typeLocator, EnumRegistry enumRegistry)
    {
        _vulkanRegistry = vulkanRegistry;
        _commandGroupGenerator = commandGroupGenerator;
        _typeLocator = typeLocator;
        _enumRegistry = enumRegistry;
    }

    public void GenerateExtensions()
    {
        foreach (var extension in _vulkanRegistry.Root.Extensions)
        {
            // Skip non-vulkan features (i.e: Vulkan sc, deprecated, obsolete, or provisional)
            if (!extension.Supported.Split(',').Contains("vulkan") ||
                extension.Provisional == "true" ||
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
                    var vkType = _vulkanRegistry.Root.Types.FirstOrDefault(x => x.Name == type.NameAttribute)
                        ?? _vulkanRegistry.Root.Types.FirstOrDefault(x => x.NameAttribute == type.NameAttribute)
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

                    enumMember.Extnumber = extension.Number!;

                    _enumRegistry.Enums[enumMember.Extends].Members[enumMember.Name] = enumMember;
                }


                extensionCommands.AddRange(requires.Commands.Select(x => x.Name));
            }

            if (extensionCommands.Count > 0)
            {
                extensionCommands = extensionCommands.Distinct().ToList();

                var extensionClassName = $"{extension.Name.ToLowerInvariant().Pascalize()}Extension";

                var commandGroupType = extension.Type switch
                {
                    "instance" => CommandGroupType.Instance,
                    "device" => CommandGroupType.Device,
                    _ => throw new InvalidOperationException($"Unknown extension type '{extension.Type}'")
                };

                _commandGroupGenerator.GenerateCommandGroup(extensionClassName, "Extensions", commandGroupType, extensionCommands);
            }
        }
    }
}