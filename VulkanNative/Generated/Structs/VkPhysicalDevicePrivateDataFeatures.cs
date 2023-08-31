using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDevicePrivateDataFeatures
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 privateData;

    public VkPhysicalDevicePrivateDataFeatures()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRIVATE_DATA_FEATURES;
    }
}