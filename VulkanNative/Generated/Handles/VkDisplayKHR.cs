using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly struct VkDisplayKHR
{
    private readonly nint _handle;

    public VkDisplayKHR(nint handle)
    {
        _handle = handle;
    }

    public static implicit operator VkDisplayKHR(nint handle)
    {
        return new VkDisplayKHR(handle);
    }

    public static implicit operator nint(VkDisplayKHR value)
    {
        return value._handle;
    }
}