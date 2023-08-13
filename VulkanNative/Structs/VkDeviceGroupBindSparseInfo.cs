﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceGroupBindSparseInfo
{
    public VkStructureType SType;
    public void* PNext;
    public uint ResourceDeviceIndex;
    public uint MemoryDeviceIndex;
}