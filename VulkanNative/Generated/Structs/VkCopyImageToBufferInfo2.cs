using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCopyImageToBufferInfo2
{
    public VkStructureType sType;
    public void* pNext;
    public VkImage srcImage;
    public VkImageLayout srcImageLayout;
    public VkBuffer dstBuffer;
    public uint regionCount;
    public VkBufferImageCopy2* pRegions;

    public VkCopyImageToBufferInfo2()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_COPY_IMAGE_TO_BUFFER_INFO_2;
    }
}