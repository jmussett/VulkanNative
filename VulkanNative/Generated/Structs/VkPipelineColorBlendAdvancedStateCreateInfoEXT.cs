using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineColorBlendAdvancedStateCreateInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 srcPremultiplied;
    public VkBool32 dstPremultiplied;
    public VkBlendOverlapEXT blendOverlap;

    public VkPipelineColorBlendAdvancedStateCreateInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_COLOR_BLEND_ADVANCED_STATE_CREATE_INFO_EXT;
    }
}