using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineRasterizationConservativeStateCreateInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkPipelineRasterizationConservativeStateCreateFlagsEXT flags;
    public VkConservativeRasterizationModeEXT conservativeRasterizationMode;
    public float extraPrimitiveOverestimationSize;

    public VkPipelineRasterizationConservativeStateCreateInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_CONSERVATIVE_STATE_CREATE_INFO_EXT;
    }
}