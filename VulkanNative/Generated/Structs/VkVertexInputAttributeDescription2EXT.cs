using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVertexInputAttributeDescription2EXT
{
    public VkStructureType sType;
    public void* pNext;
    public uint location;
    public uint binding;
    public VkFormat format;
    public uint offset;

    public VkVertexInputAttributeDescription2EXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_VERTEX_INPUT_ATTRIBUTE_DESCRIPTION_2_EXT;
    }
}