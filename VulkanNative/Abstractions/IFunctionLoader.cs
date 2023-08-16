namespace VulkanNative.Abstractions;

public interface IFunctionLoader
{
    nint GetDeviceProcAddr(VkDevice device, string name);
    nint GetInstanceProcAddr(VkInstance instance, string name);
    nint GetProcAddr(string name);
}