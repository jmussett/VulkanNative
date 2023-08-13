using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineRasterizationStateRasterizationOrderAMD
{
    public VkStructureType SType;
    public void* PNext;
    public VkRasterizationOrderAMD RasterizationOrder;
}