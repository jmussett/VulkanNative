using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly struct VkBuffer
{
    private readonly nint _handle;

    public VkBuffer(nint handle)
    {
        _handle = handle;
    }

    public static implicit operator VkBuffer(nint handle)
    {
        return new VkBuffer(handle);
    }

    public static implicit operator nint(VkBuffer value)
    {
        return value._handle;
    }
}