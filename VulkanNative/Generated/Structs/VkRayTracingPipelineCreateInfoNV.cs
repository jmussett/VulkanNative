using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRayTracingPipelineCreateInfoNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkPipelineCreateFlags flags;
    public uint stageCount;
    public VkPipelineShaderStageCreateInfo* pStages;
    public uint groupCount;
    public VkRayTracingShaderGroupCreateInfoNV* pGroups;
    public uint maxRecursionDepth;
    public VkPipelineLayout layout;
    public VkPipeline basePipelineHandle;
    public int basePipelineIndex;

    public VkRayTracingPipelineCreateInfoNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_RAY_TRACING_PIPELINE_CREATE_INFO_NV;
    }
}