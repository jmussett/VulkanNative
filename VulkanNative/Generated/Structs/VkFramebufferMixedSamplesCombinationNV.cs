using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkFramebufferMixedSamplesCombinationNV
{
    public VkStructureType SType;
    public void* PNext;
    public VkCoverageReductionModeNV CoverageReductionMode;
    public VkSampleCountFlags RasterizationSamples;
    public VkSampleCountFlags DepthStencilSamples;
    public VkSampleCountFlags ColorSamples;
}