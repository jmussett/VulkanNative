using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineRasterizationStateRasterizationOrderAMD
{
    public VkStructureType sType;
    public void* pNext;
    public VkRasterizationOrderAMD rasterizationOrder;

    public VkPipelineRasterizationStateRasterizationOrderAMD()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_STATE_RASTERIZATION_ORDER_AMD;
    }
}