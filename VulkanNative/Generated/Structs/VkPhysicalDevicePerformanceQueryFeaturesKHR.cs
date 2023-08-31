using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDevicePerformanceQueryFeaturesKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 performanceCounterQueryPools;
    public VkBool32 performanceCounterMultipleQueryPools;

    public VkPhysicalDevicePerformanceQueryFeaturesKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PERFORMANCE_QUERY_FEATURES_KHR;
    }
}