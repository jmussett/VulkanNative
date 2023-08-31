using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceGlobalPriorityQueryFeaturesKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 globalPriorityQuery;

    public VkPhysicalDeviceGlobalPriorityQueryFeaturesKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GLOBAL_PRIORITY_QUERY_FEATURES_KHR;
    }
}