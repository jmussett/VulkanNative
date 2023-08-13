using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageMemoryBarrier2
{
    public VkStructureType SType;
    public void* PNext;
    public VkPipelineStageFlags2 SrcStageMask;
    public VkAccessFlags2 SrcAccessMask;
    public VkPipelineStageFlags2 DstStageMask;
    public VkAccessFlags2 DstAccessMask;
    public VkImageLayout OldLayout;
    public VkImageLayout NewLayout;
    public uint SrcQueueFamilyIndex;
    public uint DstQueueFamilyIndex;
    public VkImage Image;
    public VkImageSubresourceRange SubresourceRange;
}