﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDescriptorSetVariableDescriptorCountAllocateInfo
{
    public VkStructureType SType;
    public void* PNext;
    public uint DescriptorSetCount;
    public uint* PDescriptorCounts;
}