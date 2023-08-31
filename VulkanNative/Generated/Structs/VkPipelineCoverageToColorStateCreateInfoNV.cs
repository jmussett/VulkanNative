using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineCoverageToColorStateCreateInfoNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkPipelineCoverageToColorStateCreateFlagsNV flags;
    public VkBool32 coverageToColorEnable;
    public uint coverageToColorLocation;

    public VkPipelineCoverageToColorStateCreateInfoNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_COVERAGE_TO_COLOR_STATE_CREATE_INFO_NV;
    }
}