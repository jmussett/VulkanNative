using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBufferCollectionCreateInfoFUCHSIA
{
    public VkStructureType sType;
    public void* pNext;
    public nint collectionToken;
}