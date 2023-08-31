using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBufferMemoryBarrier
{
    public VkStructureType sType;
    public void* pNext;
    public VkAccessFlags srcAccessMask;
    public VkAccessFlags dstAccessMask;
    public uint srcQueueFamilyIndex;
    public uint dstQueueFamilyIndex;
    public VkBuffer buffer;
    public VkDeviceSize offset;
    public VkDeviceSize size;

    public VkBufferMemoryBarrier()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_BUFFER_MEMORY_BARRIER;
    }
}