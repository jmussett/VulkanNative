using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineCoverageReductionStateCreateInfoNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkPipelineCoverageReductionStateCreateFlagsNV flags;
    public VkCoverageReductionModeNV coverageReductionMode;
}