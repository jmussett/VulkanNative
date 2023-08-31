﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImportScreenBufferInfoQNX
{
    public VkStructureType sType;
    public void* pNext;
    public nint* buffer;
}