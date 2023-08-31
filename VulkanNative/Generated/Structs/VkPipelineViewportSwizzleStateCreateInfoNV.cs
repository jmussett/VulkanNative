using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineViewportSwizzleStateCreateInfoNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkPipelineViewportSwizzleStateCreateFlagsNV flags;
    public uint viewportCount;
    public VkViewportSwizzleNV* pViewportSwizzles;

    public VkPipelineViewportSwizzleStateCreateInfoNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_SWIZZLE_STATE_CREATE_INFO_NV;
    }
}