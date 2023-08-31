using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceTimelineSemaphoreFeatures
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 timelineSemaphore;

    public VkPhysicalDeviceTimelineSemaphoreFeatures()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TIMELINE_SEMAPHORE_FEATURES;
    }
}