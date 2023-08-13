﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageFormatProperties2
{
    public VkStructureType SType;
    public void* PNext;
    public VkImageFormatProperties ImageFormatProperties;
}