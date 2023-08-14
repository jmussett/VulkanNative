using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCopyMemoryToImageIndirectCommandNV
{
    public VkDeviceAddress SrcAddress;
    public uint BufferRowLength;
    public uint BufferImageHeight;
    public VkImageSubresourceLayers ImageSubresource;
    public VkOffset3D ImageOffset;
    public VkExtent3D ImageExtent;
}