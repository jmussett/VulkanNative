using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineRasterizationDepthClipStateCreateInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkPipelineRasterizationDepthClipStateCreateFlagsEXT flags;
    public VkBool32 depthClipEnable;

    public VkPipelineRasterizationDepthClipStateCreateInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_DEPTH_CLIP_STATE_CREATE_INFO_EXT;
    }
}