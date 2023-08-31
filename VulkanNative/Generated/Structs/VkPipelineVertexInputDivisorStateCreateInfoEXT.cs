using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineVertexInputDivisorStateCreateInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public uint vertexBindingDivisorCount;
    public VkVertexInputBindingDivisorDescriptionEXT* pVertexBindingDivisors;
}