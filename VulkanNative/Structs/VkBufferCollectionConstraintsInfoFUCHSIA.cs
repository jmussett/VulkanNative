using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBufferCollectionConstraintsInfoFUCHSIA
{
    public VkStructureType SType;
    public void* PNext;
    public uint MinBufferCount;
    public uint MaxBufferCount;
    public uint MinBufferCountForCamping;
    public uint MinBufferCountForDedicatedSlack;
    public uint MinBufferCountForSharedSlack;
}