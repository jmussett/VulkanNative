using VulkanNative.Examples.Common.Utility;

namespace VulkanNative.Examples.Common;

public sealed class ColorBlendState : IDisposable
{
    public bool LogicOpEnable { get; set; }
    public VkLogicOp LogicOp { get; set; }
    public VulkanBuffer<ColorBlendAttachmentState> Attachments { get; set; } = new();
    public VulkanBuffer<float> BlendConstants { get; } = new(4, true);

    public void Dispose()
    {
        Attachments.Dispose();
        BlendConstants.Dispose();
    }
}
