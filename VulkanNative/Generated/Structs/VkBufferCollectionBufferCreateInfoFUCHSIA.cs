using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBufferCollectionBufferCreateInfoFUCHSIA
{
    public VkStructureType sType;
    public void* pNext;
    public VkBufferCollectionFUCHSIA collection;
    public uint index;
}