namespace VulkanNative.Examples.Common;

public struct PipelineRasterizationState
{
    public bool DepthClampEnable { get; set; }
    public bool RasterizerDiscardEnable { get; set; }
    public VkPolygonMode PolygonMode { get; set; }
    public VkCullModeFlags CullMode { get; set; }
    public VkFrontFace FrontFace { get; set; }
    public bool DepthBiasEnable { get; set; }
    public float DepthBiasConstantFactor { get; set; }
    public float DepthBiasClamp { get; set; }
    public float DepthBiasSlopeFactor { get; set; }
    public float LineWidth { get; set; }
}
