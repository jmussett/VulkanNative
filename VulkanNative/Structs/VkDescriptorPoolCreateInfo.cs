﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDescriptorPoolCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkDescriptorPoolCreateFlags flags;
    public uint maxSets;
    public uint poolSizeCount;
    public VkDescriptorPoolSize* pPoolSizes;
}