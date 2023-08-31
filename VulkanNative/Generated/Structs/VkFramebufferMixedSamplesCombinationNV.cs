using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkFramebufferMixedSamplesCombinationNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkCoverageReductionModeNV coverageReductionMode;
    public VkSampleCountFlags rasterizationSamples;
    public VkSampleCountFlags depthStencilSamples;
    public VkSampleCountFlags colorSamples;

    public VkFramebufferMixedSamplesCombinationNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_FRAMEBUFFER_MIXED_SAMPLES_COMBINATION_NV;
    }
}