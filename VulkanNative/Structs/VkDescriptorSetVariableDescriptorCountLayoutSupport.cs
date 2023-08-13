﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDescriptorSetVariableDescriptorCountLayoutSupport
{
    public VkStructureType sType;
    public void* pNext;
    public uint maxVariableDescriptorCount;
}