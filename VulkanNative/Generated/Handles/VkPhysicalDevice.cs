using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly struct VkPhysicalDevice
{
    private readonly nint _handle;

    public VkPhysicalDevice(nint handle)
    {
        _handle = handle;
    }

    public static implicit operator VkPhysicalDevice(nint handle)
    {
        return new VkPhysicalDevice(handle);
    }

    public static implicit operator nint(VkPhysicalDevice value)
    {
        return value._handle;
    }
}