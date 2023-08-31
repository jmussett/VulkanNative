using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDescriptorImageInfo
{
    public VkSampler sampler;
    public VkImageView imageView;
    public VkImageLayout imageLayout;
}