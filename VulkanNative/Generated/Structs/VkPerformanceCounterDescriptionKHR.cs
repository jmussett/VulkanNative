using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPerformanceCounterDescriptionKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkPerformanceCounterDescriptionFlagsKHR flags;
    public fixed byte name[(int)VulkanApiConstants.VK_MAX_DESCRIPTION_SIZE];
    public fixed byte category[(int)VulkanApiConstants.VK_MAX_DESCRIPTION_SIZE];
    public fixed byte description[(int)VulkanApiConstants.VK_MAX_DESCRIPTION_SIZE];

    public VkPerformanceCounterDescriptionKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PERFORMANCE_COUNTER_DESCRIPTION_KHR;
    }
}