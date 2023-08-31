using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkFragmentShadingRateAttachmentInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkAttachmentReference2* pFragmentShadingRateAttachment;
    public VkExtent2D shadingRateAttachmentTexelSize;

    public VkFragmentShadingRateAttachmentInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_FRAGMENT_SHADING_RATE_ATTACHMENT_INFO_KHR;
    }
}