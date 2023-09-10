namespace VulkanNative.Examples.Common;

public struct ColorBlendAttachmentState
{
    public bool BlendEnable { get; set; }
    public VkBlendFactor SrcColorBlendFactor { get; set; }
    public VkBlendFactor DstColorBlendFactor { get; set; }
    public VkBlendOp ColorBlendOp { get; set; }
    public VkBlendFactor SrcAlphaBlendFactor { get; set; }
    public VkBlendFactor DstAlphaBlendFactor { get; set; }
    public VkBlendOp AlphaBlendOp { get; set; }
    public VkColorComponentFlags ColorWriteMask { get; set; }
}