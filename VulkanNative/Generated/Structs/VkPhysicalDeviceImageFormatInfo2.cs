using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceImageFormatInfo2
{
    public VkStructureType sType;
    public void* pNext;
    public VkFormat format;
    public VkImageType type;
    public VkImageTiling tiling;
    public VkImageUsageFlags usage;
    public VkImageCreateFlags flags;

    public VkPhysicalDeviceImageFormatInfo2()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_FORMAT_INFO_2;
    }
}