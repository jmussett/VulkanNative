using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineFragmentShadingRateStateCreateInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkExtent2D FragmentSize;
    public VkFragmentShadingRateCombinerOpKHR* CombinerOps;
}