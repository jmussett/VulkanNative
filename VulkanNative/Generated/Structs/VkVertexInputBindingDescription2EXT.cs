using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVertexInputBindingDescription2EXT
{
    public VkStructureType sType;
    public void* pNext;
    public uint binding;
    public uint stride;
    public VkVertexInputRate inputRate;
    public uint divisor;

    public VkVertexInputBindingDescription2EXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_VERTEX_INPUT_BINDING_DESCRIPTION_2_EXT;
    }
}