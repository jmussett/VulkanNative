using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageMemoryBarrier
{
    public VkStructureType sType;
    public void* pNext;
    public VkAccessFlags srcAccessMask;
    public VkAccessFlags dstAccessMask;
    public VkImageLayout oldLayout;
    public VkImageLayout newLayout;
    public uint srcQueueFamilyIndex;
    public uint dstQueueFamilyIndex;
    public VkImage image;
    public VkImageSubresourceRange subresourceRange;
}