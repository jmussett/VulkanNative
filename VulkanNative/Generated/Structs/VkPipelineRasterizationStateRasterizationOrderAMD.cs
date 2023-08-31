using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineRasterizationStateRasterizationOrderAMD
{
    public VkStructureType sType;
    public void* pNext;
    public VkRasterizationOrderAMD rasterizationOrder;
}