using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMemoryAllocateFlagsInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkMemoryAllocateFlags flags;
    public uint deviceMask;
}