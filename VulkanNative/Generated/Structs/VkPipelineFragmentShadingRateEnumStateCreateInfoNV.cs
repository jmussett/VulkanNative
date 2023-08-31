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
}