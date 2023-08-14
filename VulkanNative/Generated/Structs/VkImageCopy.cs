using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageCopy
{
    public VkImageSubresourceLayers SrcSubresource;
    public VkOffset3D SrcOffset;
    public VkImageSubresourceLayers DstSubresource;
    public VkOffset3D DstOffset;
    public VkExtent3D Extent;
}