using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderingAttachmentInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkImageView imageView;
    public VkImageLayout imageLayout;
    public VkResolveModeFlags resolveMode;
    public VkImageView resolveImageView;
    public VkImageLayout resolveImageLayout;
    public VkAttachmentLoadOp loadOp;
    public VkAttachmentStoreOp storeOp;
    public VkClearValue clearValue;

    public VkRenderingAttachmentInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_RENDERING_ATTACHMENT_INFO;
    }
}