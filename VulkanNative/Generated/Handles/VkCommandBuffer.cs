using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly struct VkCommandBuffer
{
    private readonly nint _handle;

    public VkCommandBuffer(nint handle)
    {
        _handle = handle;
    }

    public static implicit operator VkCommandBuffer(nint handle)
    {
        return new VkCommandBuffer(handle);
    }

    public static implicit operator nint(VkCommandBuffer value)
    {
        return value._handle;
    }
}