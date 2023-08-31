using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineCoverageReductionStateCreateInfoNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkPipelineCoverageReductionStateCreateFlagsNV flags;
    public VkCoverageReductionModeNV coverageReductionMode;

    public VkPipelineCoverageReductionStateCreateInfoNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_COVERAGE_REDUCTION_STATE_CREATE_INFO_NV;
    }
}