using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageSubresource
{
    public VkImageAspectFlags AspectMask;
    public uint MipLevel;
    public uint ArrayLayer;
}