using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly struct VkVideoSessionKHR
{
    private readonly nint _handle;

    public VkVideoSessionKHR(nint handle)
    {
        _handle = handle;
    }

    public static implicit operator VkVideoSessionKHR(nint handle)
    {
        return new VkVideoSessionKHR(handle);
    }

    public static implicit operator nint(VkVideoSessionKHR value)
    {
        return value._handle;
    }
}