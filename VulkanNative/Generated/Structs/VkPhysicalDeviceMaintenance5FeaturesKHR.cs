using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceMaintenance5FeaturesKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 maintenance5;

    public VkPhysicalDeviceMaintenance5FeaturesKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_5_FEATURES_KHR;
    }
}