using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBufferCollectionBufferCreateInfoFUCHSIA
{
    public VkStructureType sType;
    public void* pNext;
    public VkBufferCollectionFUCHSIA collection;
    public uint index;

    public VkBufferCollectionBufferCreateInfoFUCHSIA()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_BUFFER_COLLECTION_BUFFER_CREATE_INFO_FUCHSIA;
    }
}