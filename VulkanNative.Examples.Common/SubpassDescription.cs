using VulkanNative.Examples.Common.Utility;

namespace VulkanNative.Examples.Common;

public class SubpassDescription : IDisposable
{
    public VkPipelineBindPoint BindPoint { get; set; }

    public VulkanBuffer<VkAttachmentReference> InputAttachments { get; set; } = new();
    public VulkanBuffer<VkAttachmentReference> ColorAttachments { get; set; } = new();
    public VulkanBuffer<VkAttachmentReference> ResolveReferences { get; set; } = new();
    public VkAttachmentReference? DepthStencilAttachment { get; set; }

    public VulkanBuffer<uint> PreserveAttachments { get; set; } = new();

    public void Dispose()
    {
        InputAttachments?.Dispose();
        ColorAttachments?.Dispose();
        ResolveReferences?.Dispose();
        PreserveAttachments?.Dispose();
    }
}