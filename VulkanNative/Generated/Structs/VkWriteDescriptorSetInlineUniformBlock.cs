using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkWriteDescriptorSetInlineUniformBlock
{
    public VkStructureType sType;
    public void* pNext;
    public uint dataSize;
    public void* pData;

    public VkWriteDescriptorSetInlineUniformBlock()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_INLINE_UNIFORM_BLOCK;
    }
}