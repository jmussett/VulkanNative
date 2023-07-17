using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly struct VkFence
{
    private readonly nint _handle;

    public VkFence(nint handle)
    {
        _handle = handle;
    }

    public static implicit operator VkFence(nint handle)
    {
        return new VkFence(handle);
    }

    public static implicit operator nint(VkFence value)
    {
        return value._handle;
    }
}