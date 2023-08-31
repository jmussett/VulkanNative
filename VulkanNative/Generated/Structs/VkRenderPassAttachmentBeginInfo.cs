using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderPassAttachmentBeginInfo
{
    public VkStructureType sType;
    public void* pNext;
    public uint attachmentCount;
    public VkImageView* pAttachments;

    public VkRenderPassAttachmentBeginInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_RENDER_PASS_ATTACHMENT_BEGIN_INFO;
    }
}