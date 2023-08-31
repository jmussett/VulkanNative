using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceMemoryProperties2
{
    public VkStructureType sType;
    public void* pNext;
    public VkPhysicalDeviceMemoryProperties memoryProperties;

    public VkPhysicalDeviceMemoryProperties2()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_PROPERTIES_2;
    }
}