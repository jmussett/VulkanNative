using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageSubresourceLayers
{
    public VkImageAspectFlags aspectMask;
    public uint mipLevel;
    public uint baseArrayLayer;
    public uint layerCount;
}