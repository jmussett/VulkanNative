using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDevicePerformanceQueryPropertiesKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 allowCommandBufferQueryCopies;

    public VkPhysicalDevicePerformanceQueryPropertiesKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PERFORMANCE_QUERY_PROPERTIES_KHR;
    }
}