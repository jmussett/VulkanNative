using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkGraphicsPipelineShaderGroupsCreateInfoNV
{
    public VkStructureType sType;
    public void* pNext;
    public uint groupCount;
    public VkGraphicsShaderGroupCreateInfoNV* pGroups;
    public uint pipelineCount;
    public VkPipeline* pPipelines;

    public VkGraphicsPipelineShaderGroupsCreateInfoNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_GRAPHICS_PIPELINE_SHADER_GROUPS_CREATE_INFO_NV;
    }
}