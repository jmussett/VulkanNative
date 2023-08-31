using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRayTracingPipelineCreateInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkPipelineCreateFlags flags;
    public uint stageCount;
    public VkPipelineShaderStageCreateInfo* pStages;
    public uint groupCount;
    public VkRayTracingShaderGroupCreateInfoKHR* pGroups;
    public uint maxPipelineRayRecursionDepth;
    public VkPipelineLibraryCreateInfoKHR* pLibraryInfo;
    public VkRayTracingPipelineInterfaceCreateInfoKHR* pLibraryInterface;
    public VkPipelineDynamicStateCreateInfo* pDynamicState;
    public VkPipelineLayout layout;
    public VkPipeline basePipelineHandle;
    public int basePipelineIndex;

    public VkRayTracingPipelineCreateInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_RAY_TRACING_PIPELINE_CREATE_INFO_KHR;
    }
}