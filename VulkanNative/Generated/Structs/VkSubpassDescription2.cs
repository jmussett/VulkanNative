using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSubpassDescription2
{
    public VkStructureType sType;
    public void* pNext;
    public VkSubpassDescriptionFlags flags;
    public VkPipelineBindPoint pipelineBindPoint;
    public uint viewMask;
    public uint inputAttachmentCount;
    public VkAttachmentReference2* pInputAttachments;
    public uint colorAttachmentCount;
    public VkAttachmentReference2* pColorAttachments;
    public VkAttachmentReference2* pResolveAttachments;
    public VkAttachmentReference2* pDepthStencilAttachment;
    public uint preserveAttachmentCount;
    public uint* pPreserveAttachments;

    public VkSubpassDescription2()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_SUBPASS_DESCRIPTION_2;
    }
}