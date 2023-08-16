using VulkanNative.Abstractions;

namespace VulkanNative;

public class VulkanLoader
{
    private readonly IFunctionLoader _functionLoader;
    
    public ExtensionLoader Extensions { get; }

    public VulkanLoader() : this(new DefaultFunctionLoader())
    {
    }

    public VulkanLoader(IFunctionLoader vulkanLoader)
    {
        _functionLoader = vulkanLoader;
        Extensions = new ExtensionLoader(vulkanLoader);
    }

    public VkGlobalCommands LoadGlobalCommands()
    {
        return new VkGlobalCommands(_functionLoader);
    }

    public VkInstanceCommands LoadInstanceCommands(VkInstance instance)
    {
        return new VkInstanceCommands(instance, _functionLoader);
    }

    public VkDeviceCommands LoadDeviceCommands(VkDevice device)
    {
        return new VkDeviceCommands(device, _functionLoader);
    }
}