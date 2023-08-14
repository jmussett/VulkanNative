using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkGraphicsPipelineCreateInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkPipelineCreateFlags Flags;
    public uint StageCount;
    public VkPipelineShaderStageCreateInfo* PStages;
    public VkPipelineVertexInputStateCreateInfo* PVertexInputState;
    public VkPipelineInputAssemblyStateCreateInfo* PInputAssemblyState;
    public VkPipelineTessellationStateCreateInfo* PTessellationState;
    public VkPipelineViewportStateCreateInfo* PViewportState;
    public VkPipelineRasterizationStateCreateInfo* PRasterizationState;
    public VkPipelineMultisampleStateCreateInfo* PMultisampleState;
    public VkPipelineDepthStencilStateCreateInfo* PDepthStencilState;
    public VkPipelineColorBlendStateCreateInfo* PColorBlendState;
    public VkPipelineDynamicStateCreateInfo* PDynamicState;
    public VkPipelineLayout Layout;
    public VkRenderPass RenderPass;
    public uint Subpass;
    public VkPipeline BasePipelineHandle;
    public int BasePipelineIndex;
}