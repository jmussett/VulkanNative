﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBlitImageInfo2
{
    public VkStructureType SType;
    public void* PNext;
    public VkImage SrcImage;
    public VkImageLayout SrcImageLayout;
    public VkImage DstImage;
    public VkImageLayout DstImageLayout;
    public uint RegionCount;
    public VkImageBlit2* PRegions;
    public VkFilter Filter;
}