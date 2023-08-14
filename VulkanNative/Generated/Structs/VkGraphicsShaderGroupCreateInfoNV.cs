using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkGraphicsShaderGroupCreateInfoNV
{
    public VkStructureType SType;
    public void* PNext;
    public uint StageCount;
    public VkPipelineShaderStageCreateInfo* PStages;
    public VkPipelineVertexInputStateCreateInfo* PVertexInputState;
    public VkPipelineTessellationStateCreateInfo* PTessellationState;
}