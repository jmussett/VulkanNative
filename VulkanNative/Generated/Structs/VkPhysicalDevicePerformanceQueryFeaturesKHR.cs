using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDevicePerformanceQueryFeaturesKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 performanceCounterQueryPools;
    public VkBool32 performanceCounterMultipleQueryPools;
}