using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkInputAttachmentAspectReference
{
    public uint subpass;
    public uint inputAttachmentIndex;
    public VkImageAspectFlags aspectMask;
}