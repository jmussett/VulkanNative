﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAndroidHardwareBufferUsageANDROID
{
    public VkStructureType SType;
    public void* PNext;
    public ulong AndroidHardwareBufferUsage;
}