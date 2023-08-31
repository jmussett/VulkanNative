using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineViewportCoarseSampleOrderStateCreateInfoNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkCoarseSampleOrderTypeNV sampleOrderType;
    public uint customSampleOrderCount;
    public VkCoarseSampleOrderCustomNV* pCustomSampleOrders;

    public VkPipelineViewportCoarseSampleOrderStateCreateInfoNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_COARSE_SAMPLE_ORDER_STATE_CREATE_INFO_NV;
    }
}