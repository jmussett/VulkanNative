using VulkanNative.Generator.Registries;
using VulkanNative.Generator.Registry;
using VulkanNative.Generator.SyntaxGenerators;

namespace VulkanNative.Generator;

internal class FeatureGenerator
{
    private readonly VkRegistry _vkRegistry;
    private readonly CommandGroupGenerator _commandGroupGenerator;
    private readonly TypeLocator _typeLocator;
    private readonly EnumRegistry _enumRegistry;

    private readonly IReadOnlyDictionary<string, VkCommand> _commandLookup;
    private readonly IReadOnlyDictionary<string, VkType> _handleLookup;

    public FeatureGenerator(VkRegistry vkRegistry, CommandGroupGenerator commandGroupGenerator, TypeLocator typeLocator, EnumRegistry enumRegistry)
    {
        _vkRegistry = vkRegistry;
        _commandGroupGenerator = commandGroupGenerator;
        _typeLocator = typeLocator;
        _enumRegistry = enumRegistry;
        _commandLookup = vkRegistry.CreateCommandLookup();
        _handleLookup = vkRegistry.CreateHandleLookup();
    }

    public void GenerateFeatures()
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

                    _enumRegistry.Enums[enumMember.Extends].Members[enumMember.Name] = enumMember;
                }
            }
        }

        _commandGroupGenerator.GenerateCommandGroup("VkGlobalCommands", "Commands", globalCommands);
        _commandGroupGenerator.GenerateCommandGroup("VkInstanceCommands", "Commands", instanceCommands);
        _commandGroupGenerator.GenerateCommandGroup("VkDeviceCommands", "Commands", deviceCommands);
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