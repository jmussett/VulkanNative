using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkClearAttachment
{
    public VkImageAspectFlags aspectMask;
    public uint colorAttachment;
    public VkClearValue clearValue;
}