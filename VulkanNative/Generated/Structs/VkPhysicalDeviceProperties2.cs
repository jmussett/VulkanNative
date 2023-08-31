using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceProperties2
{
    public VkStructureType sType;
    public void* pNext;
    public VkPhysicalDeviceProperties properties;

    public VkPhysicalDeviceProperties2()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROPERTIES_2;
    }
}