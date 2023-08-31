using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDescriptorPoolInlineUniformBlockCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public uint maxInlineUniformBlockBindings;

    public VkDescriptorPoolInlineUniformBlockCreateInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_DESCRIPTOR_POOL_INLINE_UNIFORM_BLOCK_CREATE_INFO;
    }
}