using VulkanNative.Generator.Registries;
using VulkanNative.Generator.Registry;
using VulkanNative.Generator.VulkanRegistry;

namespace VulkanNative.Generator.SyntaxGenerators;

internal class FeatureGenerator
{
    private readonly VulkanApiRegistry _vulkanRegistry;
    private readonly CommandGroupGenerator _commandGroupGenerator;
    private readonly TypeLocator _typeLocator;
    private readonly EnumRegistry _enumRegistry;

    public FeatureGenerator(VulkanApiRegistry vulkanRegistry, CommandGroupGenerator commandGroupGenerator, TypeLocator typeLocator, EnumRegistry enumRegistry)
    {
        _vulkanRegistry = vulkanRegistry;
        _commandGroupGenerator = commandGroupGenerator;
        _typeLocator = typeLocator;
        _enumRegistry = enumRegistry;
        
    }

    public void GenerateFeatures()
    {
        var globalCommands = new List<string>();
        var instanceCommands = new List<string>();
        var deviceCommands = new List<string>();

        var commandLookup = _vulkanRegistry.Root.CreateCommandLookup();
        var handleLookup = _vulkanRegistry.Root.CreateHandleLookup();

        foreach (var feature in _vulkanRegistry.Root.Feature)
        {
            // Skip non-vulkan features (i.e: Vulkan sc only)
            if (!feature.Api.Split(',').Contains("vulkan"))
            {
                continue;
            }

            foreach (var requires in feature.Requires)
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

                foreach (var command in requires.Commands)
                {
                    if (!commandLookup.TryGetValue(command.Name, out var commandDefinition))
                    {
                        throw new InvalidOperationException($"Unable to find command definition '{command.Name}'");
                    }

                    var functionName = commandDefinition.Proto.Name;
                    var firstParamType = commandDefinition.Params.FirstOrDefault()?.Type;

                    if (functionName == "vkGetDeviceProcAddr" || functionName == "vkGetInstanceProcAddr")
                    {
                        continue;
                    }

                    if (firstParamType is not null && IsHandleInheritsFrom(handleLookup, firstParamType, "VkDevice"))
                    {
                        deviceCommands.Add(command.Name);
                    }
                    else if (firstParamType is not null && IsHandleInheritsFrom(handleLookup, firstParamType, "VkInstance"))
                    {
                        instanceCommands.Add(command.Name);
                    }
                    else
                    {
                        globalCommands.Add(command.Name);
                    }
                }

                foreach (var enumMember in requires.Enums)
                {
                    if (enumMember.Extends is null)
                    {
                        continue;
                    }

                    _enumRegistry.Enums.TryAdd(enumMember.Extends, new EnumDefinition());

                    _enumRegistry.Enums[enumMember.Extends].Members[enumMember.Name] = enumMember;
                }
            }
        }

        _commandGroupGenerator.GenerateCommandGroup("VkGlobalCommands", "Commands", globalCommands);
        _commandGroupGenerator.GenerateCommandGroup("VkInstanceCommands", "Commands", instanceCommands);
        _commandGroupGenerator.GenerateCommandGroup("VkDeviceCommands", "Commands", deviceCommands);
    }

    private bool IsHandleInheritsFrom(IReadOnlyDictionary<string, VkType> handleLookup, string handleType, string parentType)
    {
        var current = handleType;

        while (current is not null && handleLookup.TryGetValue(current, out var handle))
        {
            if (handle.Name == parentType || handle.Parent == parentType)
                return true;

            current = handle.Parent;
        }

        return false;
    }
}