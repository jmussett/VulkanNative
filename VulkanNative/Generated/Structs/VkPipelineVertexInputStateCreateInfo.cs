using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineVertexInputStateCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkPipelineVertexInputStateCreateFlags flags;
    public uint vertexBindingDescriptionCount;
    public VkVertexInputBindingDescription* pVertexBindingDescriptions;
    public uint vertexAttributeDescriptionCount;
    public VkVertexInputAttributeDescription* pVertexAttributeDescriptions;

    public VkPipelineVertexInputStateCreateInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_VERTEX_INPUT_STATE_CREATE_INFO;
    }
}