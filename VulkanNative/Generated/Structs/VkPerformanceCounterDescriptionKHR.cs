using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPerformanceCounterDescriptionKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkPerformanceCounterDescriptionFlagsKHR Flags;
    public fixed byte Name[(int)VulkanApiConstants.VK_MAX_DESCRIPTION_SIZE];
    public fixed byte Category[(int)VulkanApiConstants.VK_MAX_DESCRIPTION_SIZE];
    public fixed byte Description[(int)VulkanApiConstants.VK_MAX_DESCRIPTION_SIZE];
}