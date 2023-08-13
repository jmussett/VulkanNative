using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineShaderStageRequiredSubgroupSizeCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public uint requiredSubgroupSize;
}