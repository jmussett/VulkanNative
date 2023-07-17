using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly struct VkCommandPool
{
    private readonly nint _handle;

    public VkCommandPool(nint handle)
    {
        _handle = handle;
    }

    public static implicit operator VkCommandPool(nint handle)
    {
        return new VkCommandPool(handle);
    }

    public static implicit operator nint(VkCommandPool value)
    {
        return value._handle;
    }
}