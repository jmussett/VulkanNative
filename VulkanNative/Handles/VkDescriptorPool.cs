using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly struct VkDescriptorPool
{
    private readonly nint _handle;

    public VkDescriptorPool(nint handle)
    {
        _handle = handle;
    }

    public static implicit operator VkDescriptorPool(nint handle)
    {
        return new VkDescriptorPool(handle);
    }

    public static implicit operator nint(VkDescriptorPool value)
    {
        return value._handle;
    }
}