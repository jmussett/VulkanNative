using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageConstraintsInfoFUCHSIA
{
    public VkStructureType SType;
    public void* PNext;
    public uint FormatConstraintsCount;
    public VkImageFormatConstraintsInfoFUCHSIA* PFormatConstraints;
    public VkBufferCollectionConstraintsInfoFUCHSIA BufferCollectionConstraints;
    public VkImageConstraintsInfoFlagsFUCHSIA Flags;
}