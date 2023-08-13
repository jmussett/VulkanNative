using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMemoryAllocateFlagsInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkMemoryAllocateFlags Flags;
    public uint DeviceMask;
}