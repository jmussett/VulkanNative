using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceSparseImageFormatInfo2
{
    public VkStructureType sType;
    public void* pNext;
    public VkFormat format;
    public VkImageType type;
    public VkSampleCountFlags samples;
    public VkImageUsageFlags usage;
    public VkImageTiling tiling;

    public VkPhysicalDeviceSparseImageFormatInfo2()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SPARSE_IMAGE_FORMAT_INFO_2;
    }
}