using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkQueryPoolPerformanceQueryCreateInfoINTEL
{
    public VkStructureType sType;
    public void* pNext;
    public VkQueryPoolSamplingModeINTEL performanceCountersSampling;

    public VkQueryPoolPerformanceQueryCreateInfoINTEL()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_QUERY_POOL_PERFORMANCE_QUERY_CREATE_INFO_INTEL;
    }
}