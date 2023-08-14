using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineViewportCoarseSampleOrderStateCreateInfoNV
{
    public VkStructureType SType;
    public void* PNext;
    public VkCoarseSampleOrderTypeNV SampleOrderType;
    public uint CustomSampleOrderCount;
    public VkCoarseSampleOrderCustomNV* PCustomSampleOrders;
}