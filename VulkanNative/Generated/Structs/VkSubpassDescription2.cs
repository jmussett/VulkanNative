using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSubpassDescription2
{
    public VkStructureType SType;
    public void* PNext;
    public VkSubpassDescriptionFlags Flags;
    public VkPipelineBindPoint PipelineBindPoint;
    public uint ViewMask;
    public uint InputAttachmentCount;
    public VkAttachmentReference2* PInputAttachments;
    public uint ColorAttachmentCount;
    public VkAttachmentReference2* PColorAttachments;
    public VkAttachmentReference2* PResolveAttachments;
    public VkAttachmentReference2* PDepthStencilAttachment;
    public uint PreserveAttachmentCount;
    public uint* PPreserveAttachments;
}