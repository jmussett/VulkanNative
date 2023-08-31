using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageMemoryBarrier2
{
    public VkStructureType sType;
    public void* pNext;
    public VkPipelineStageFlags2 srcStageMask;
    public VkAccessFlags2 srcAccessMask;
    public VkPipelineStageFlags2 dstStageMask;
    public VkAccessFlags2 dstAccessMask;
    public VkImageLayout oldLayout;
    public VkImageLayout newLayout;
    public uint srcQueueFamilyIndex;
    public uint dstQueueFamilyIndex;
    public VkImage image;
    public VkImageSubresourceRange subresourceRange;

    public VkImageMemoryBarrier2()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_IMAGE_MEMORY_BARRIER_2;
    }
}