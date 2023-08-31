using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkQueueFamilyGlobalPriorityPropertiesKHR
{
    public VkStructureType sType;
    public void* pNext;
    public uint priorityCount;
    public VkQueueGlobalPriorityKHR* priorities;

    public VkQueueFamilyGlobalPriorityPropertiesKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_QUEUE_FAMILY_GLOBAL_PRIORITY_PROPERTIES_KHR;
    }
}