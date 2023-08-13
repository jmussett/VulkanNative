﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBindImagePlaneMemoryInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkImageAspectFlags planeAspect;
}