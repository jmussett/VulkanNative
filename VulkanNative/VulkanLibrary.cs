using VulkanNative.Abstractions;

namespace VulkanNative;

internal class VulkanLibrary
{
    private readonly IVulkanLoader _vulkanLoader;

    public VulkanLibrary() : this(new DefaultVulkanLoader())
    {
    }

    public VulkanLibrary(IVulkanLoader vulkanLoader)
    {
        _vulkanLoader = vulkanLoader;
    }

    public VkGlobalCommands LoadGlobalCommands()
    {
        // TODO: internal constructor with IVulkanLoader
        return new VkGlobalCommands();
    }

    public VkInstanceCommands LoadInstanceCommands(VkInstance instance)
    {
        // TODO: internal constructor with VkInstance and IVulkanLoader
        return new VkInstanceCommands();
    }

    public VkDeviceCommands LoadDeviceCommands(VkDevice device)
    {
        // TODO: internal constructor with VkDevice and IVulkanLoader
        return new VkDeviceCommands();
    }

    public T LoadExtension<T>(VkDevice device) where T : IDeviceExtension, new()
    {
        var extension = new T();

        extension.LoadCommands(device, _vulkanLoader);

        return extension;
    }

    public T LoadExtension<T>(VkInstance instance) where T : IInstanceExtension, new()
    {
        var extension = new T();

        extension.LoadCommands(instance, _vulkanLoader);

        return extension;
    }
}

