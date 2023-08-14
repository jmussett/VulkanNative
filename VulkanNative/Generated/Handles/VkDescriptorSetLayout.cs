using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly struct VkDescriptorSetLayout
{
    private readonly nint _handle;

    public VkDescriptorSetLayout(nint handle)
    {
        _handle = handle;
    }

    public static implicit operator VkDescriptorSetLayout(nint handle)
    {
        return new VkDescriptorSetLayout(handle);
    }

    public static implicit operator nint(VkDescriptorSetLayout value)
    {
        return value._handle;
    }
}