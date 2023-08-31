using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageSubresource
{
    public VkImageAspectFlags aspectMask;
    public uint mipLevel;
    public uint arrayLayer;
}