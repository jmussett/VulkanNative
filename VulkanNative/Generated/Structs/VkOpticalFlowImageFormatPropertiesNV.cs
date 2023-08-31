using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkOpticalFlowImageFormatPropertiesNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkFormat format;

    public VkOpticalFlowImageFormatPropertiesNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_OPTICAL_FLOW_IMAGE_FORMAT_PROPERTIES_NV;
    }
}