﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkQueueFamilyProperties2
{
    public VkStructureType SType;
    public void* PNext;
    public VkQueueFamilyProperties QueueFamilyProperties;
}