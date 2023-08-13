using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineFragmentShadingRateEnumStateCreateInfoNV
{
    public VkStructureType SType;
    public void* PNext;
    public VkFragmentShadingRateTypeNV ShadingRateType;
    public VkFragmentShadingRateNV ShadingRate;
    public VkFragmentShadingRateCombinerOpKHR* CombinerOps;
}