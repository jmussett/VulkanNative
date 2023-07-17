using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkGraphicsPipelineCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkPipelineCreateFlags flags;
    public uint stageCount;
    public VkPipelineShaderStageCreateInfo* pStages;
    public VkPipelineVertexInputStateCreateInfo* pVertexInputState;
    public VkPipelineInputAssemblyStateCreateInfo* pInputAssemblyState;
    public VkPipelineTessellationStateCreateInfo* pTessellationState;
    public VkPipelineViewportStateCreateInfo* pViewportState;
    public VkPipelineRasterizationStateCreateInfo* pRasterizationState;
    public VkPipelineMultisampleStateCreateInfo* pMultisampleState;
    public VkPipelineDepthStencilStateCreateInfo* pDepthStencilState;
    public VkPipelineColorBlendStateCreateInfo* pColorBlendState;
    public VkPipelineDynamicStateCreateInfo* pDynamicState;
    public VkPipelineLayout layout;
    public VkRenderPass renderPass;
    public uint subpass;
    public VkPipeline basePipelineHandle;
    public int basePipelineIndex;
}