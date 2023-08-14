using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCopyImageToMemoryInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkHostImageCopyFlagsEXT Flags;
    public VkImage SrcImage;
    public VkImageLayout SrcImageLayout;
    public uint RegionCount;
    public VkImageToMemoryCopyEXT* PRegions;
}