﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBufferMemoryRequirementsInfo2
{
    public VkStructureType SType;
    public void* PNext;
    public VkBuffer Buffer;
}