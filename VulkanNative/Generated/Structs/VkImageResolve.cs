using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageResolve
{
    public VkImageSubresourceLayers srcSubresource;
    public VkOffset3D srcOffset;
    public VkImageSubresourceLayers dstSubresource;
    public VkOffset3D dstOffset;
    public VkExtent3D extent;
}