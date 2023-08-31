using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineVertexInputDivisorStateCreateInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public uint vertexBindingDivisorCount;
    public VkVertexInputBindingDivisorDescriptionEXT* pVertexBindingDivisors;

    public VkPipelineVertexInputDivisorStateCreateInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_VERTEX_INPUT_DIVISOR_STATE_CREATE_INFO_EXT;
    }
}