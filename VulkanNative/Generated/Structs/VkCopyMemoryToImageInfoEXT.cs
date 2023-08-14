using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCopyMemoryToImageInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkHostImageCopyFlagsEXT Flags;
    public VkImage DstImage;
    public VkImageLayout DstImageLayout;
    public uint RegionCount;
    public VkMemoryToImageCopyEXT* PRegions;
}