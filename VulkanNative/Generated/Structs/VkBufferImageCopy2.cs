using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBufferImageCopy2
{
    public VkStructureType sType;
    public void* pNext;
    public VkDeviceSize bufferOffset;
    public uint bufferRowLength;
    public uint bufferImageHeight;
    public VkImageSubresourceLayers imageSubresource;
    public VkOffset3D imageOffset;
    public VkExtent3D imageExtent;

    public VkBufferImageCopy2()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_BUFFER_IMAGE_COPY_2;
    }
}