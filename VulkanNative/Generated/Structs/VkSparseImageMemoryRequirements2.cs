﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSparseImageMemoryRequirements2
{
    public VkStructureType SType;
    public void* PNext;
    public VkSparseImageMemoryRequirements MemoryRequirements;
}