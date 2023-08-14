using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageMemoryBarrier
{
    public VkStructureType SType;
    public void* PNext;
    public VkAccessFlags SrcAccessMask;
    public VkAccessFlags DstAccessMask;
    public VkImageLayout OldLayout;
    public VkImageLayout NewLayout;
    public uint SrcQueueFamilyIndex;
    public uint DstQueueFamilyIndex;
    public VkImage Image;
    public VkImageSubresourceRange SubresourceRange;
}