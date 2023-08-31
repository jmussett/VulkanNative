using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceFeatures2
{
    public VkStructureType sType;
    public void* pNext;
    public VkPhysicalDeviceFeatures features;

    public VkPhysicalDeviceFeatures2()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FEATURES_2;
    }
}