using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCopyImageToImageInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkHostImageCopyFlagsEXT flags;
    public VkImage srcImage;
    public VkImageLayout srcImageLayout;
    public VkImage dstImage;
    public VkImageLayout dstImageLayout;
    public uint regionCount;
    public VkImageCopy2* pRegions;

    public VkCopyImageToImageInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_COPY_IMAGE_TO_IMAGE_INFO_EXT;
    }
}