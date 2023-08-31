using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceQueueGlobalPriorityCreateInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkQueueGlobalPriorityKHR globalPriority;

    public VkDeviceQueueGlobalPriorityCreateInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_DEVICE_QUEUE_GLOBAL_PRIORITY_CREATE_INFO_KHR;
    }
}