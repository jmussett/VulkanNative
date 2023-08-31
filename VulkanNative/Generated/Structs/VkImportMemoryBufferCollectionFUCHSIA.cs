using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImportMemoryBufferCollectionFUCHSIA
{
    public VkStructureType sType;
    public void* pNext;
    public VkBufferCollectionFUCHSIA collection;
    public uint index;

    public VkImportMemoryBufferCollectionFUCHSIA()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_IMPORT_MEMORY_BUFFER_COLLECTION_FUCHSIA;
    }
}