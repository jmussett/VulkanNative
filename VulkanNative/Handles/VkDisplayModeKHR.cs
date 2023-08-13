using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly struct VkDisplayModeKHR
{
    private readonly nint _handle;

    public VkDisplayModeKHR(nint handle)
    {
        _handle = handle;
    }

    public static implicit operator VkDisplayModeKHR(nint handle)
    {
        return new VkDisplayModeKHR(handle);
    }

    public static implicit operator nint(VkDisplayModeKHR value)
    {
        return value._handle;
    }
}