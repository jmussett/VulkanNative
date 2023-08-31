using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderingFragmentShadingRateAttachmentInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkImageView imageView;
    public VkImageLayout imageLayout;
    public VkExtent2D shadingRateAttachmentTexelSize;

    public VkRenderingFragmentShadingRateAttachmentInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_RENDERING_FRAGMENT_SHADING_RATE_ATTACHMENT_INFO_KHR;
    }
}