using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceMaintenance4Properties
{
    public VkStructureType sType;
    public void* pNext;
    public VkDeviceSize maxBufferSize;

    public VkPhysicalDeviceMaintenance4Properties()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_4_PROPERTIES;
    }
}