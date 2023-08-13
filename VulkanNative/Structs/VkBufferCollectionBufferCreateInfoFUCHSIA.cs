using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBufferCollectionBufferCreateInfoFUCHSIA
{
    public VkStructureType SType;
    public void* PNext;
    public VkBufferCollectionFUCHSIA Collection;
    public uint Index;
}