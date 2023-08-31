using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCopyBufferToImageInfo2
{
    public VkStructureType sType;
    public void* pNext;
    public VkBuffer srcBuffer;
    public VkImage dstImage;
    public VkImageLayout dstImageLayout;
    public uint regionCount;
    public VkBufferImageCopy2* pRegions;

    public VkCopyBufferToImageInfo2()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_COPY_BUFFER_TO_IMAGE_INFO_2;
    }
}