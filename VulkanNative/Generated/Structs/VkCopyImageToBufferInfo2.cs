using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCopyImageToBufferInfo2
{
    public VkStructureType SType;
    public void* PNext;
    public VkImage SrcImage;
    public VkImageLayout SrcImageLayout;
    public VkBuffer DstBuffer;
    public uint RegionCount;
    public VkBufferImageCopy2* PRegions;
}