using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderingFragmentShadingRateAttachmentInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkImageView ImageView;
    public VkImageLayout ImageLayout;
    public VkExtent2D ShadingRateAttachmentTexelSize;
}