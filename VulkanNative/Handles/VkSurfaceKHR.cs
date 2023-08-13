using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly struct VkSurfaceKHR
{
    private readonly nint _handle;

    public VkSurfaceKHR(nint handle)
    {
        _handle = handle;
    }

    public static implicit operator VkSurfaceKHR(nint handle)
    {
        return new VkSurfaceKHR(handle);
    }

    public static implicit operator nint(VkSurfaceKHR value)
    {
        return value._handle;
    }
}