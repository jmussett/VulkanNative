using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAttachmentReference
{
    public uint Attachment;
    public VkImageLayout Layout;
}