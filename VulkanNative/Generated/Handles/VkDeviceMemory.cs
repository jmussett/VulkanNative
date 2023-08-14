using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly struct VkDeviceMemory
{
    private readonly nint _handle;

    public VkDeviceMemory(nint handle)
    {
        _handle = handle;
    }

    public static implicit operator VkDeviceMemory(nint handle)
    {
        return new VkDeviceMemory(handle);
    }

    public static implicit operator nint(VkDeviceMemory value)
    {
        return value._handle;
    }
}