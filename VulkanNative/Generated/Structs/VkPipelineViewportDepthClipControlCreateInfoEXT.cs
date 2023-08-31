using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineViewportDepthClipControlCreateInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 negativeOneToOne;

    public VkPipelineViewportDepthClipControlCreateInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_DEPTH_CLIP_CONTROL_CREATE_INFO_EXT;
    }
}