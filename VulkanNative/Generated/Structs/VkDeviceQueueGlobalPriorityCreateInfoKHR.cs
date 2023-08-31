using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceQueueGlobalPriorityCreateInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkQueueGlobalPriorityKHR globalPriority;
}