using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly struct VkQueryPool
{
    private readonly nint _handle;

    public VkQueryPool(nint handle)
    {
        _handle = handle;
    }

    public static implicit operator VkQueryPool(nint handle)
    {
        return new VkQueryPool(handle);
    }

    public static implicit operator nint(VkQueryPool value)
    {
        return value._handle;
    }
}