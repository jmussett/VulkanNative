﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMemoryZirconHandlePropertiesFUCHSIA
{
    public VkStructureType sType;
    public void* pNext;
    public uint memoryTypeBits;
}