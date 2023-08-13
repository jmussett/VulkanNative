using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkFragmentShadingRateAttachmentInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkAttachmentReference2* PFragmentShadingRateAttachment;
    public VkExtent2D ShadingRateAttachmentTexelSize;
}