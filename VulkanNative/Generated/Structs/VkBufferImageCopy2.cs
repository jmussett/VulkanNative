using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBufferImageCopy2
{
    public VkStructureType SType;
    public void* PNext;
    public VkDeviceSize BufferOffset;
    public uint BufferRowLength;
    public uint BufferImageHeight;
    public VkImageSubresourceLayers ImageSubresource;
    public VkOffset3D ImageOffset;
    public VkExtent3D ImageExtent;
}