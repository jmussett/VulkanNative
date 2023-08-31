using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceGroupProperties
{
    public VkStructureType sType;
    public void* pNext;
    public uint physicalDeviceCount;
    public VkPhysicalDevice* physicalDevices;
    public VkBool32 subsetAllocation;

    public VkPhysicalDeviceGroupProperties()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GROUP_PROPERTIES;
    }
}