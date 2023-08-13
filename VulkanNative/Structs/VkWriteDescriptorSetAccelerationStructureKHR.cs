﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkWriteDescriptorSetAccelerationStructureKHR
{
    public VkStructureType SType;
    public void* PNext;
    public uint AccelerationStructureCount;
    public VkAccelerationStructureKHR* PAccelerationStructures;
}