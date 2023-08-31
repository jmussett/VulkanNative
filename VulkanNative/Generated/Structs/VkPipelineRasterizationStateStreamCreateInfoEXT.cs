using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineRasterizationStateStreamCreateInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkPipelineRasterizationStateStreamCreateFlagsEXT flags;
    public uint rasterizationStream;

    public VkPipelineRasterizationStateStreamCreateInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_STATE_STREAM_CREATE_INFO_EXT;
    }
}