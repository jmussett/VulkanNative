using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageToMemoryCopyEXT
{
    public VkStructureType sType;
    public void* pNext;
    public void* pHostPointer;
    public uint memoryRowLength;
    public uint memoryImageHeight;
    public VkImageSubresourceLayers imageSubresource;
    public VkOffset3D imageOffset;
    public VkExtent3D imageExtent;

    public VkImageToMemoryCopyEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_IMAGE_TO_MEMORY_COPY_EXT;
    }
}