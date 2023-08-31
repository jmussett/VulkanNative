using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkFramebufferAttachmentImageInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkImageCreateFlags flags;
    public VkImageUsageFlags usage;
    public uint width;
    public uint height;
    public uint layerCount;
    public uint viewFormatCount;
    public VkFormat* pViewFormats;

    public VkFramebufferAttachmentImageInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_FRAMEBUFFER_ATTACHMENT_IMAGE_INFO;
    }
}