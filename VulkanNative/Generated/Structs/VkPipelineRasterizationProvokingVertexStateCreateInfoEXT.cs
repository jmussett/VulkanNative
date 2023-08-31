using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineRasterizationProvokingVertexStateCreateInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkProvokingVertexModeEXT provokingVertexMode;

    public VkPipelineRasterizationProvokingVertexStateCreateInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_PROVOKING_VERTEX_STATE_CREATE_INFO_EXT;
    }
}