using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkComputePipelineCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkPipelineCreateFlags flags;
    public VkPipelineShaderStageCreateInfo stage;
    public VkPipelineLayout layout;
    public VkPipeline basePipelineHandle;
    public int basePipelineIndex;

    public VkComputePipelineCreateInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_COMPUTE_PIPELINE_CREATE_INFO;
    }
}