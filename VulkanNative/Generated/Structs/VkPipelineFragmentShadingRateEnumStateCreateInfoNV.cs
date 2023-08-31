using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineFragmentShadingRateEnumStateCreateInfoNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkFragmentShadingRateTypeNV shadingRateType;
    public VkFragmentShadingRateNV shadingRate;
    public VkFragmentShadingRateCombinerOpKHR* combinerOps;

    public VkPipelineFragmentShadingRateEnumStateCreateInfoNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_FRAGMENT_SHADING_RATE_ENUM_STATE_CREATE_INFO_NV;
    }
}