using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly struct VkDescriptorSet
{
    private readonly nint _handle;

    public VkDescriptorSet(nint handle)
    {
        _handle = handle;
    }

    public static implicit operator VkDescriptorSet(nint handle)
    {
        return new VkDescriptorSet(handle);
    }

    public static implicit operator nint(VkDescriptorSet value)
    {
        return value._handle;
    }
}