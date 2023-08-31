using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceMaintenance3Properties
{
    public VkStructureType sType;
    public void* pNext;
    public uint maxPerSetDescriptors;
    public VkDeviceSize maxMemoryAllocationSize;

    public VkPhysicalDeviceMaintenance3Properties()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_3_PROPERTIES;
    }
}