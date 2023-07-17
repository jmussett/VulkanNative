using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly struct VkImage
{
    private readonly nint _handle;

    public VkImage(nint handle)
    {
        _handle = handle;
    }

    public static implicit operator VkImage(nint handle)
    {
        return new VkImage(handle);
    }

    public static implicit operator nint(VkImage value)
    {
        return value._handle;
    }
}