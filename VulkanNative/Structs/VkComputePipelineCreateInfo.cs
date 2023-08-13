using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkComputePipelineCreateInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkPipelineCreateFlags Flags;
    public VkPipelineShaderStageCreateInfo Stage;
    public VkPipelineLayout Layout;
    public VkPipeline BasePipelineHandle;
    public int BasePipelineIndex;
}