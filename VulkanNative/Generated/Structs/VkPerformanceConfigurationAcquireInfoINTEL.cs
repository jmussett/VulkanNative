using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPerformanceConfigurationAcquireInfoINTEL
{
    public VkStructureType sType;
    public void* pNext;
    public VkPerformanceConfigurationTypeINTEL type;

    public VkPerformanceConfigurationAcquireInfoINTEL()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PERFORMANCE_CONFIGURATION_ACQUIRE_INFO_INTEL;
    }
}