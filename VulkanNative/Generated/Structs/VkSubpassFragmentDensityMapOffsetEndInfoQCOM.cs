using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSubpassFragmentDensityMapOffsetEndInfoQCOM
{
    public VkStructureType sType;
    public void* pNext;
    public uint fragmentDensityOffsetCount;
    public VkOffset2D* pFragmentDensityOffsets;

    public VkSubpassFragmentDensityMapOffsetEndInfoQCOM()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_SUBPASS_FRAGMENT_DENSITY_MAP_OFFSET_END_INFO_QCOM;
    }
}