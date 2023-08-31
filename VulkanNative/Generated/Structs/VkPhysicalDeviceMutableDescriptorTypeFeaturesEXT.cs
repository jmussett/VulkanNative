using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceMutableDescriptorTypeFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 mutableDescriptorType;

    public VkPhysicalDeviceMutableDescriptorTypeFeaturesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MUTABLE_DESCRIPTOR_TYPE_FEATURES_EXT;
    }
}