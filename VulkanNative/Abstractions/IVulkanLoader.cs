namespace VulkanNative.Abstractions;

public interface IVulkanLoader
{
    nint GetDeviceProcAddr(VkDevice device, string name);
    nint GetInstanceProcAddr(VkInstance instance, string name);
    nint GetProcAddr(string name);
}