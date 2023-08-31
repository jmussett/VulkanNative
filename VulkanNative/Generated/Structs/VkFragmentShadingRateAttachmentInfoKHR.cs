using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkFragmentShadingRateAttachmentInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkAttachmentReference2* pFragmentShadingRateAttachment;
    public VkExtent2D shadingRateAttachmentTexelSize;
}