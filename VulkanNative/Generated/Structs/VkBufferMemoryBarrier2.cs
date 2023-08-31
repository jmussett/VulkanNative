using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBufferMemoryBarrier2
{
    public VkStructureType sType;
    public void* pNext;
    public VkPipelineStageFlags2 srcStageMask;
    public VkAccessFlags2 srcAccessMask;
    public VkPipelineStageFlags2 dstStageMask;
    public VkAccessFlags2 dstAccessMask;
    public uint srcQueueFamilyIndex;
    public uint dstQueueFamilyIndex;
    public VkBuffer buffer;
    public VkDeviceSize offset;
    public VkDeviceSize size;

    public VkBufferMemoryBarrier2()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_BUFFER_MEMORY_BARRIER_2;
    }
}