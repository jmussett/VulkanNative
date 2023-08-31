using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineExecutableStatisticKHR
{
    public VkStructureType sType;
    public void* pNext;
    public fixed byte name[(int)VulkanApiConstants.VK_MAX_DESCRIPTION_SIZE];
    public fixed byte description[(int)VulkanApiConstants.VK_MAX_DESCRIPTION_SIZE];
    public VkPipelineExecutableStatisticFormatKHR format;
    public VkPipelineExecutableStatisticValueKHR value;

    public VkPipelineExecutableStatisticKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_EXECUTABLE_STATISTIC_KHR;
    }
}