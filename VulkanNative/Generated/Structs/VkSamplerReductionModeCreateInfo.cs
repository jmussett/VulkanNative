using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSamplerReductionModeCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkSamplerReductionMode reductionMode;

    public VkSamplerReductionModeCreateInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_SAMPLER_REDUCTION_MODE_CREATE_INFO;
    }
}