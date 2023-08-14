using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly struct VkFramebuffer
{
    private readonly nint _handle;

    public VkFramebuffer(nint handle)
    {
        _handle = handle;
    }

    public static implicit operator VkFramebuffer(nint handle)
    {
        return new VkFramebuffer(handle);
    }

    public static implicit operator nint(VkFramebuffer value)
    {
        return value._handle;
    }
}