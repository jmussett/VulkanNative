using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceSwapchainMaintenance1FeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 swapchainMaintenance1;

    public VkPhysicalDeviceSwapchainMaintenance1FeaturesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SWAPCHAIN_MAINTENANCE_1_FEATURES_EXT;
    }
}