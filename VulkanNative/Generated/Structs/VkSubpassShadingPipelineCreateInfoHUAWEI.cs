using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSubpassShadingPipelineCreateInfoHUAWEI
{
    public VkStructureType sType;
    public void* pNext;
    public VkRenderPass renderPass;
    public uint subpass;

    public VkSubpassShadingPipelineCreateInfoHUAWEI()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_SUBPASS_SHADING_PIPELINE_CREATE_INFO_HUAWEI;
    }
}