using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMemoryBarrier
{
    public VkStructureType sType;
    public void* pNext;
    public VkAccessFlags srcAccessMask;
    public VkAccessFlags dstAccessMask;

    public VkMemoryBarrier()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_MEMORY_BARRIER;
    }
}