using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageViewHandleInfoNVX
{
    public VkStructureType SType;
    public void* PNext;
    public VkImageView ImageView;
    public VkDescriptorType DescriptorType;
    public VkSampler Sampler;
}