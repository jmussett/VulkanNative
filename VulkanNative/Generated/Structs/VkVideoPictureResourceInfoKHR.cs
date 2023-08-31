using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoPictureResourceInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkOffset2D codedOffset;
    public VkExtent2D codedExtent;
    public uint baseArrayLayer;
    public VkImageView imageViewBinding;

    public VkVideoPictureResourceInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_PICTURE_RESOURCE_INFO_KHR;
    }
}