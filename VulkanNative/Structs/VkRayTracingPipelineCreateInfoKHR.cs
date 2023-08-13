using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRayTracingPipelineCreateInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkPipelineCreateFlags Flags;
    public uint StageCount;
    public VkPipelineShaderStageCreateInfo* PStages;
    public uint GroupCount;
    public VkRayTracingShaderGroupCreateInfoKHR* PGroups;
    public uint MaxPipelineRayRecursionDepth;
    public VkPipelineLibraryCreateInfoKHR* PLibraryInfo;
    public VkRayTracingPipelineInterfaceCreateInfoKHR* PLibraryInterface;
    public VkPipelineDynamicStateCreateInfo* PDynamicState;
    public VkPipelineLayout Layout;
    public VkPipeline BasePipelineHandle;
    public int BasePipelineIndex;
}