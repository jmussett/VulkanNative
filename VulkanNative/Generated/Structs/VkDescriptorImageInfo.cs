using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDescriptorImageInfo
{
    public VkSampler Sampler;
    public VkImageView ImageView;
    public VkImageLayout ImageLayout;
}