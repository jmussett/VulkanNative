using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkFramebufferAttachmentsCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public uint attachmentImageInfoCount;
    public VkFramebufferAttachmentImageInfo* pAttachmentImageInfos;
}