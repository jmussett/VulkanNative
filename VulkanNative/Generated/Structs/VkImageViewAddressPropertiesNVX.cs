using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageViewAddressPropertiesNVX
{
    public VkStructureType sType;
    public void* pNext;
    public VkDeviceAddress deviceAddress;
    public VkDeviceSize size;

    public VkImageViewAddressPropertiesNVX()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_IMAGE_VIEW_ADDRESS_PROPERTIES_NVX;
    }
}