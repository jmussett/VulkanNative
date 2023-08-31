using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDevicePageableDeviceLocalMemoryFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 pageableDeviceLocalMemory;

    public VkPhysicalDevicePageableDeviceLocalMemoryFeaturesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PAGEABLE_DEVICE_LOCAL_MEMORY_FEATURES_EXT;
    }
}