using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageBlit
{
    public VkImageSubresourceLayers srcSubresource;
    public VkOffset3D* srcOffsets;
    public VkImageSubresourceLayers dstSubresource;
    public VkOffset3D* dstOffsets;
}