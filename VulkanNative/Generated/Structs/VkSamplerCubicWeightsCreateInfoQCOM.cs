using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSamplerCubicWeightsCreateInfoQCOM
{
    public VkStructureType sType;
    public void* pNext;
    public VkCubicFilterWeightsQCOM cubicWeights;

    public VkSamplerCubicWeightsCreateInfoQCOM()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_SAMPLER_CUBIC_WEIGHTS_CREATE_INFO_QCOM;
    }
}