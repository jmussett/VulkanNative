using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineFragmentShadingRateStateCreateInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkExtent2D fragmentSize;
    public VkFragmentShadingRateCombinerOpKHR* combinerOps;

    public VkPipelineFragmentShadingRateStateCreateInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_FRAGMENT_SHADING_RATE_STATE_CREATE_INFO_KHR;
    }
}