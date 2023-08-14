using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineShaderStageRequiredSubgroupSizeCreateInfo
{
    public VkStructureType SType;
    public void* PNext;
    public uint RequiredSubgroupSize;
}