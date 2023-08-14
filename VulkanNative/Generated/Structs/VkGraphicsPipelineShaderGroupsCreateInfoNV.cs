using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkGraphicsPipelineShaderGroupsCreateInfoNV
{
    public VkStructureType SType;
    public void* PNext;
    public uint GroupCount;
    public VkGraphicsShaderGroupCreateInfoNV* PGroups;
    public uint PipelineCount;
    public VkPipeline* PPipelines;
}