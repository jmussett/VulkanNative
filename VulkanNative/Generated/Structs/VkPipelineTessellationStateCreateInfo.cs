using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineTessellationStateCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkPipelineTessellationStateCreateFlags flags;
    public uint patchControlPoints;

    public VkPipelineTessellationStateCreateInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_TESSELLATION_STATE_CREATE_INFO;
    }
}