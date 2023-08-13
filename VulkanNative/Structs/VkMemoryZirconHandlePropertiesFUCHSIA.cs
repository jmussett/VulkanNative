using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMemoryZirconHandlePropertiesFUCHSIA
{
    public VkStructureType SType;
    public void* PNext;
    public uint MemoryTypeBits;
}