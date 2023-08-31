using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBufferCollectionCreateInfoFUCHSIA
{
    public VkStructureType sType;
    public void* pNext;
    public nint collectionToken;

    public VkBufferCollectionCreateInfoFUCHSIA()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_BUFFER_COLLECTION_CREATE_INFO_FUCHSIA;
    }
}