using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBufferCollectionConstraintsInfoFUCHSIA
{
    public VkStructureType sType;
    public void* pNext;
    public uint minBufferCount;
    public uint maxBufferCount;
    public uint minBufferCountForCamping;
    public uint minBufferCountForDedicatedSlack;
    public uint minBufferCountForSharedSlack;
}