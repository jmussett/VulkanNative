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
}