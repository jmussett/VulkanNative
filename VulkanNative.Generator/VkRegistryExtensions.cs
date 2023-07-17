using VulkanNative.Generator.Registry;

namespace VulkanNative.Generator;

internal static class VkRegistryExtensions
{
    public static IReadOnlyDictionary<string, VkCommand> CreateCommandLookup(this VkRegistry vkRegistry)
    {
        return vkRegistry.Commands
            .Where(x => x.Api is null || x.Api == "vulkan")
            .Where(x => x.Alias is null) // TODO: manage aliases
            .ToDictionary(x => x.Proto.Name, x => x);
    }

    public static IReadOnlyDictionary<string, VkType> CreateHandleLookup(this VkRegistry vkRegistry)
    {
        return vkRegistry.Types
            .Where(x => x.Category == "handle")
            .Where(x => x.Alias is null) // TODO: manage aliases
            .ToDictionary(x => x.Name, x => x);
    }
}
