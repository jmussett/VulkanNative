using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSubpassDescription
{
    public VkSubpassDescriptionFlags Flags;
    public VkPipelineBindPoint PipelineBindPoint;
    public uint InputAttachmentCount;
    public VkAttachmentReference* PInputAttachments;
    public uint ColorAttachmentCount;
    public VkAttachmentReference* PColorAttachments;
    public VkAttachmentReference* PResolveAttachments;
    public VkAttachmentReference* PDepthStencilAttachment;
    public uint PreserveAttachmentCount;
    public uint* PPreserveAttachments;
}