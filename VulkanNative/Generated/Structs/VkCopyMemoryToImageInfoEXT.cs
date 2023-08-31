using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCopyMemoryToImageInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkHostImageCopyFlagsEXT flags;
    public VkImage dstImage;
    public VkImageLayout dstImageLayout;
    public uint regionCount;
    public VkMemoryToImageCopyEXT* pRegions;
}