﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMemoryHostPointerPropertiesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public uint MemoryTypeBits;
}