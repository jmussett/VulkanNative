using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageViewHandleInfoNVX
{
    public VkStructureType sType;
    public void* pNext;
    public VkImageView imageView;
    public VkDescriptorType descriptorType;
    public VkSampler sampler;
}