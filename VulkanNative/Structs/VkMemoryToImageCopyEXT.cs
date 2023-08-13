using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMemoryToImageCopyEXT
{
    public VkStructureType SType;
    public void* PNext;
    public void* PHostPointer;
    public uint MemoryRowLength;
    public uint MemoryImageHeight;
    public VkImageSubresourceLayers ImageSubresource;
    public VkOffset3D ImageOffset;
    public VkExtent3D ImageExtent;
}