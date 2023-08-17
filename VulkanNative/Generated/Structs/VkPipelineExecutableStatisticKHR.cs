using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineExecutableStatisticKHR
{
    public VkStructureType SType;
    public void* PNext;
    public fixed byte Name[(int)VulkanApiConstants.VK_MAX_DESCRIPTION_SIZE];
    public fixed byte Description[(int)VulkanApiConstants.VK_MAX_DESCRIPTION_SIZE];
    public VkPipelineExecutableStatisticFormatKHR Format;
    public VkPipelineExecutableStatisticValueKHR Value;
}