using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDevicePushDescriptorPropertiesKHR
{
    public VkStructureType sType;
    public void* pNext;
    public uint maxPushDescriptors;

    public VkPhysicalDevicePushDescriptorPropertiesKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PUSH_DESCRIPTOR_PROPERTIES_KHR;
    }
}