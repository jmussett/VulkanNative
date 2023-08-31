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
}