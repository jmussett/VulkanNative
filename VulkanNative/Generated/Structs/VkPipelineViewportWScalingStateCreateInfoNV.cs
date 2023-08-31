using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineViewportWScalingStateCreateInfoNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 viewportWScalingEnable;
    public uint viewportCount;
    public VkViewportWScalingNV* pViewportWScalings;

    public VkPipelineViewportWScalingStateCreateInfoNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_W_SCALING_STATE_CREATE_INFO_NV;
    }
}