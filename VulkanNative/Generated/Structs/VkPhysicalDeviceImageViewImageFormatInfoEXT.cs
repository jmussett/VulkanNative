using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceImageViewImageFormatInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkImageViewType imageViewType;

    public VkPhysicalDeviceImageViewImageFormatInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_VIEW_IMAGE_FORMAT_INFO_EXT;
    }
}