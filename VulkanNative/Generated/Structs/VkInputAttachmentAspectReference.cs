using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkInputAttachmentAspectReference
{
    public uint Subpass;
    public uint InputAttachmentIndex;
    public VkImageAspectFlags AspectMask;
}