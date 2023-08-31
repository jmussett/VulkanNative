using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineLayoutCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkPipelineLayoutCreateFlags flags;
    public uint setLayoutCount;
    public VkDescriptorSetLayout* pSetLayouts;
    public uint pushConstantRangeCount;
    public VkPushConstantRange* pPushConstantRanges;

    public VkPipelineLayoutCreateInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_LAYOUT_CREATE_INFO;
    }
}