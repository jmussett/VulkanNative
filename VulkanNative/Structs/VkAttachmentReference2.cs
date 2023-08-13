using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAttachmentReference2
{
    public VkStructureType SType;
    public void* PNext;
    public uint Attachment;
    public VkImageLayout Layout;
    public VkImageAspectFlags AspectMask;
}