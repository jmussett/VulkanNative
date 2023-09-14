using System.Diagnostics.CodeAnalysis;

namespace VulkanNative.Examples.Common;

public sealed class GraphicsPipelineDefinition
{
    public required RenderPass RenderPass { get; set; }
    public required PipelineLayout PipelineLayout { get; set; }
    public VkDynamicState[] DynamicStates { get; set; } = Array.Empty<VkDynamicState>();
    public VertexInputState? VertexInputState { get; set; } = null;
    public InputAssemblyState? InputAssemblyState { get; set; } = null;
    public ViewportState? ViewportState { get; set; } = null;
    public PipelineRasterizationState? RasterizationState { get; set; } = null;
    public PipelineMultisampleState? MultisampleState { get; set; } = null;
    public ColorBlendState? ColorBlendState { get; set; } = null;
    public ShaderStage[] Stages { get; set; } = Array.Empty<ShaderStage>();
    public uint Subpass { get; set; }
    public Pipeline? BasePipeline { get; set; }
    public int BasePipelineIndex { get; set; }

    public GraphicsPipelineDefinition()
    {
    }

    [SetsRequiredMembers]
    public GraphicsPipelineDefinition(RenderPass renderPass, PipelineLayout pipelineLayout)
    {
        RenderPass = renderPass;
        PipelineLayout = pipelineLayout;
    }
}
