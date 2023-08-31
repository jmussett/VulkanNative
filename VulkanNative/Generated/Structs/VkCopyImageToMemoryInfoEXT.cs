using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCopyImageToMemoryInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkHostImageCopyFlagsEXT flags;
    public VkImage srcImage;
    public VkImageLayout srcImageLayout;
    public uint regionCount;
    public VkImageToMemoryCopyEXT* pRegions;

    public VkCopyImageToMemoryInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_COPY_IMAGE_TO_MEMORY_INFO_EXT;
    }
}