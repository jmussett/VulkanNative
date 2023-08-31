using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkGraphicsShaderGroupCreateInfoNV
{
    public VkStructureType sType;
    public void* pNext;
    public uint stageCount;
    public VkPipelineShaderStageCreateInfo* pStages;
    public VkPipelineVertexInputStateCreateInfo* pVertexInputState;
    public VkPipelineTessellationStateCreateInfo* pTessellationState;

    public VkGraphicsShaderGroupCreateInfoNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_GRAPHICS_SHADER_GROUP_CREATE_INFO_NV;
    }
}