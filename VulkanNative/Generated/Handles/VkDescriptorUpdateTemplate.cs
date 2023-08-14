using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly struct VkDescriptorUpdateTemplate
{
    private readonly nint _handle;

    public VkDescriptorUpdateTemplate(nint handle)
    {
        _handle = handle;
    }

    public static implicit operator VkDescriptorUpdateTemplate(nint handle)
    {
        return new VkDescriptorUpdateTemplate(handle);
    }

    public static implicit operator nint(VkDescriptorUpdateTemplate value)
    {
        return value._handle;
    }
}