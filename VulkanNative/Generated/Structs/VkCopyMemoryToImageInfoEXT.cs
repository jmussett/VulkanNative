using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCopyMemoryToImageInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkHostImageCopyFlagsEXT flags;
    public VkImage dstImage;
    public VkImageLayout dstImageLayout;
    public uint regionCount;
    public VkMemoryToImageCopyEXT* pRegions;

    public VkCopyMemoryToImageInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_COPY_MEMORY_TO_IMAGE_INFO_EXT;
    }
}