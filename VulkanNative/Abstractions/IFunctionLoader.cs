namespace VulkanNative.Abstractions;

public interface IFunctionLoader
{
    nint GetDeviceProcAddr(VkDevice device, ReadOnlySpan<char> name);
    nint GetInstanceProcAddr(VkInstance instance, ReadOnlySpan<char> name);
    nint GetProcAddr(string name);
}