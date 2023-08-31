using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDependencyInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkDependencyFlags dependencyFlags;
    public uint memoryBarrierCount;
    public VkMemoryBarrier2* pMemoryBarriers;
    public uint bufferMemoryBarrierCount;
    public VkBufferMemoryBarrier2* pBufferMemoryBarriers;
    public uint imageMemoryBarrierCount;
    public VkImageMemoryBarrier2* pImageMemoryBarriers;

    public VkDependencyInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_DEPENDENCY_INFO;
    }
}