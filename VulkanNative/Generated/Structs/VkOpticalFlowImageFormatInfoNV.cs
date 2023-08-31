using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkOpticalFlowImageFormatInfoNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkOpticalFlowUsageFlagsNV usage;

    public VkOpticalFlowImageFormatInfoNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_OPTICAL_FLOW_IMAGE_FORMAT_INFO_NV;
    }
}