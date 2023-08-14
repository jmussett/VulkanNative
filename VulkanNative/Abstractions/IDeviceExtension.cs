namespace VulkanNative.Abstractions;

public interface IDeviceExtension
{
    void LoadCommands(VkDevice device, IVulkanLoader vulkanLoader);
}
