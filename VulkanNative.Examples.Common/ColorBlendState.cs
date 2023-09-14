namespace VulkanNative.Examples.Common;

public sealed class ColorBlendState
{
    public bool LogicOpEnable { get; set; }
    public VkLogicOp LogicOp { get; set; }
    public ColorBlendAttachmentState[] Attachments { get; set; } = Array.Empty<ColorBlendAttachmentState>();
    public float[] BlendConstants { get; } = new[] { 0f, 0f, 0f, 0f};
}
