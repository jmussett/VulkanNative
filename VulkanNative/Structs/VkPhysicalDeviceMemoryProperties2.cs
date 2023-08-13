﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceMemoryProperties2
{
    public VkStructureType SType;
    public void* PNext;
    public VkPhysicalDeviceMemoryProperties MemoryProperties;
}