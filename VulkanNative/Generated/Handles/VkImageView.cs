using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly struct VkImageView
{
    private readonly nint _handle;

    public VkImageView(nint handle)
    {
        _handle = handle;
    }

    public static implicit operator VkImageView(nint handle)
    {
        return new VkImageView(handle);
    }

    public static implicit operator nint(VkImageView value)
    {
        return value._handle;
    }
}