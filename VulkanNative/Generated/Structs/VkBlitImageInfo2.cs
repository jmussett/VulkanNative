using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBlitImageInfo2
{
    public VkStructureType sType;
    public void* pNext;
    public VkImage srcImage;
    public VkImageLayout srcImageLayout;
    public VkImage dstImage;
    public VkImageLayout dstImageLayout;
    public uint regionCount;
    public VkImageBlit2* pRegions;
    public VkFilter filter;
}