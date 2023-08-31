using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMemoryAllocateFlagsInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkMemoryAllocateFlags flags;
    public uint deviceMask;

    public VkMemoryAllocateFlagsInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_FLAGS_INFO;
    }
}