using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDescriptorPoolInlineUniformBlockCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public uint maxInlineUniformBlockBindings;
}