using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceGroupDeviceCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public uint physicalDeviceCount;
    public VkPhysicalDevice* pPhysicalDevices;

    public VkDeviceGroupDeviceCreateInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_DEVICE_GROUP_DEVICE_CREATE_INFO;
    }
}