using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceMaintenance4Features
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 maintenance4;

    public VkPhysicalDeviceMaintenance4Features()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_4_FEATURES;
    }
}