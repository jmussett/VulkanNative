using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageSubresourceRange
{
    public VkImageAspectFlags aspectMask;
    public uint baseMipLevel;
    public uint levelCount;
    public uint baseArrayLayer;
    public uint layerCount;
}