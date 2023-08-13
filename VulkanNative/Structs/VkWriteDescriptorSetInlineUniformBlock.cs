using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkWriteDescriptorSetInlineUniformBlock
{
    public VkStructureType sType;
    public void* pNext;
    public uint dataSize;
    public void* pData;
}