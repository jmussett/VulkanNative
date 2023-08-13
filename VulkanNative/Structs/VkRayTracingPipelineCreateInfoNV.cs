using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRayTracingPipelineCreateInfoNV
{
    public VkStructureType SType;
    public void* PNext;
    public VkPipelineCreateFlags Flags;
    public uint StageCount;
    public VkPipelineShaderStageCreateInfo* PStages;
    public uint GroupCount;
    public VkRayTracingShaderGroupCreateInfoNV* PGroups;
    public uint MaxRecursionDepth;
    public VkPipelineLayout Layout;
    public VkPipeline BasePipelineHandle;
    public int BasePipelineIndex;
}