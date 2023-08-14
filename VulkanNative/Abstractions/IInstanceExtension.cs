namespace VulkanNative.Abstractions;

public interface IInstanceExtension
{
    void LoadCommands(VkInstance instance, IVulkanLoader vulkanLoader);
}

