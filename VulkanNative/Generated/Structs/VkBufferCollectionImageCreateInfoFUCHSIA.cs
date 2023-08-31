using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBufferCollectionImageCreateInfoFUCHSIA
{
    public VkStructureType sType;
    public void* pNext;
    public VkBufferCollectionFUCHSIA collection;
    public uint index;

    public VkBufferCollectionImageCreateInfoFUCHSIA()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_BUFFER_COLLECTION_IMAGE_CREATE_INFO_FUCHSIA;
    }
}