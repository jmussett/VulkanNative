using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineViewportExclusiveScissorStateCreateInfoNV
{
    public VkStructureType sType;
    public void* pNext;
    public uint exclusiveScissorCount;
    public VkRect2D* pExclusiveScissors;

    public VkPipelineViewportExclusiveScissorStateCreateInfoNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_EXCLUSIVE_SCISSOR_STATE_CREATE_INFO_NV;
    }
}