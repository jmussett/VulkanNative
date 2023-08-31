using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDescriptorAddressInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkDeviceAddress address;
    public VkDeviceSize range;
    public VkFormat format;

    public VkDescriptorAddressInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_DESCRIPTOR_ADDRESS_INFO_EXT;
    }
}