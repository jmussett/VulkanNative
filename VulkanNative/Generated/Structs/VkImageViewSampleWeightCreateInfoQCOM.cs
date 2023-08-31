using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageViewSampleWeightCreateInfoQCOM
{
    public VkStructureType sType;
    public void* pNext;
    public VkOffset2D filterCenter;
    public VkExtent2D filterSize;
    public uint numPhases;

    public VkImageViewSampleWeightCreateInfoQCOM()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_IMAGE_VIEW_SAMPLE_WEIGHT_CREATE_INFO_QCOM;
    }
}