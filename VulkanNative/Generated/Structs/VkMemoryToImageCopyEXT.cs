using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMemoryToImageCopyEXT
{
    public VkStructureType sType;
    public void* pNext;
    public void* pHostPointer;
    public uint memoryRowLength;
    public uint memoryImageHeight;
    public VkImageSubresourceLayers imageSubresource;
    public VkOffset3D imageOffset;
    public VkExtent3D imageExtent;

    public VkMemoryToImageCopyEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_MEMORY_TO_IMAGE_COPY_EXT;
    }
}