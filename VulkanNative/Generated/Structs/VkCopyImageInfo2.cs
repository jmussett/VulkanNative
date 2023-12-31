﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCopyImageInfo2
{
    public VkStructureType sType;
    public void* pNext;
    public VkImage srcImage;
    public VkImageLayout srcImageLayout;
    public VkImage dstImage;
    public VkImageLayout dstImageLayout;
    public uint regionCount;
    public VkImageCopy2* pRegions;

    public VkCopyImageInfo2()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_COPY_IMAGE_INFO_2;
    }
}