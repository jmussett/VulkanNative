namespace VulkanNative.Examples.Common;

public class SubpassDescription
{
    public VkPipelineBindPoint BindPoint { get; set; }

    public VkAttachmentReference[] InputAttachments { get; set; } = Array.Empty<VkAttachmentReference>();
    public VkAttachmentReference[] ColorAttachments { get; set; } = Array.Empty<VkAttachmentReference>();
    public VkAttachmentReference[] ResolveAttachments { get; set; } = Array.Empty<VkAttachmentReference>();
    public VkAttachmentReference? DepthStencilAttachment { get; set; }

    public uint[] PreserveAttachments { get; set; } = Array.Empty<uint>();
}