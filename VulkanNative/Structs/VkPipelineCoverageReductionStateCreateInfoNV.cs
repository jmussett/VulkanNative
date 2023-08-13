using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineCoverageReductionStateCreateInfoNV
{
    public VkStructureType SType;
    public void* PNext;
    public VkPipelineCoverageReductionStateCreateFlagsNV Flags;
    public VkCoverageReductionModeNV CoverageReductionMode;
}