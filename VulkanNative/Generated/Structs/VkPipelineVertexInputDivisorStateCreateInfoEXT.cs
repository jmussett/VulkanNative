using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineVertexInputDivisorStateCreateInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public uint VertexBindingDivisorCount;
    public VkVertexInputBindingDivisorDescriptionEXT* PVertexBindingDivisors;
}