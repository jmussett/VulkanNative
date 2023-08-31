using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceTimelineSemaphoreProperties
{
    public VkStructureType sType;
    public void* pNext;
    public ulong maxTimelineSemaphoreValueDifference;

    public VkPhysicalDeviceTimelineSemaphoreProperties()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TIMELINE_SEMAPHORE_PROPERTIES;
    }
}