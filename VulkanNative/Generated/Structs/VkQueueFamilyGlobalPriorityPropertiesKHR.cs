using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkQueueFamilyGlobalPriorityPropertiesKHR
{
    public VkStructureType sType;
    public void* pNext;
    public uint priorityCount;
    public VkQueueGlobalPriorityKHR* priorities;
}