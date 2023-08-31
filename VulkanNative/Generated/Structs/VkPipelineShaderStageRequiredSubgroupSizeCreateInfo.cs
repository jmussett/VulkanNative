using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineShaderStageRequiredSubgroupSizeCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public uint requiredSubgroupSize;

    public VkPipelineShaderStageRequiredSubgroupSizeCreateInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_REQUIRED_SUBGROUP_SIZE_CREATE_INFO;
    }
}