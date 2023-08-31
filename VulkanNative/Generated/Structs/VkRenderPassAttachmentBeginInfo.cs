using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderPassAttachmentBeginInfo
{
    public VkStructureType sType;
    public void* pNext;
    public uint attachmentCount;
    public VkImageView* pAttachments;
}