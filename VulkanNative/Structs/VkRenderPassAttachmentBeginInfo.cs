﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderPassAttachmentBeginInfo
{
    public VkStructureType SType;
    public void* PNext;
    public uint AttachmentCount;
    public VkImageView* PAttachments;
}