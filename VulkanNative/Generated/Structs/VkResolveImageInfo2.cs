﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkResolveImageInfo2
{
    public VkStructureType sType;
    public void* pNext;
    public VkImage srcImage;
    public VkImageLayout srcImageLayout;
    public VkImage dstImage;
    public VkImageLayout dstImageLayout;
    public uint regionCount;
    public VkImageResolve2* pRegions;

    public VkResolveImageInfo2()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_RESOLVE_IMAGE_INFO_2;
    }
}