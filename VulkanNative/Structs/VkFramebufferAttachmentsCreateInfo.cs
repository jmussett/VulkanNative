using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkFramebufferAttachmentsCreateInfo
{
    public VkStructureType SType;
    public void* PNext;
    public uint AttachmentImageInfoCount;
    public VkFramebufferAttachmentImageInfo* PAttachmentImageInfos;
}