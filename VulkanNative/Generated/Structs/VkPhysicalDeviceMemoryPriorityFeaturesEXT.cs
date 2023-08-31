using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceMemoryPriorityFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 memoryPriority;

    public VkPhysicalDeviceMemoryPriorityFeaturesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_PRIORITY_FEATURES_EXT;
    }
}