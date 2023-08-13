using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCopyBufferToImageInfo2
{
    public VkStructureType SType;
    public void* PNext;
    public VkBuffer SrcBuffer;
    public VkImage DstImage;
    public VkImageLayout DstImageLayout;
    public uint RegionCount;
    public VkBufferImageCopy2* PRegions;
}