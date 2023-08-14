﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMemoryWin32HandlePropertiesKHR
{
    public VkStructureType SType;
    public void* PNext;
    public uint MemoryTypeBits;
}