using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSubpassDescription
{
    public VkSubpassDescriptionFlags flags;
    public VkPipelineBindPoint pipelineBindPoint;
    public uint inputAttachmentCount;
    public VkAttachmentReference* pInputAttachments;
    public uint colorAttachmentCount;
    public VkAttachmentReference* pColorAttachments;
    public VkAttachmentReference* pResolveAttachments;
    public VkAttachmentReference* pDepthStencilAttachment;
    public uint preserveAttachmentCount;
    public uint* pPreserveAttachments;
}