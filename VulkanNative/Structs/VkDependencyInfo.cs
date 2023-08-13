using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDependencyInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkDependencyFlags DependencyFlags;
    public uint MemoryBarrierCount;
    public VkMemoryBarrier2* PMemoryBarriers;
    public uint BufferMemoryBarrierCount;
    public VkBufferMemoryBarrier2* PBufferMemoryBarriers;
    public uint ImageMemoryBarrierCount;
    public VkImageMemoryBarrier2* PImageMemoryBarriers;
}