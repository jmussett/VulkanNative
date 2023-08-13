﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBindImageMemoryInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkImage Image;
    public VkDeviceMemory Memory;
    public VkDeviceSize MemoryOffset;
}