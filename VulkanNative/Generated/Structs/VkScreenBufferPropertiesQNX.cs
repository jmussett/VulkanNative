using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkScreenBufferPropertiesQNX
{
    public VkStructureType SType;
    public void* PNext;
    public VkDeviceSize AllocationSize;
    public uint MemoryTypeBits;
}