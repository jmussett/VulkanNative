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
}