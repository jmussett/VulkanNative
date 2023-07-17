﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDescriptorUpdateTemplateEntry
{
    public uint dstBinding;
    public uint dstArrayElement;
    public uint descriptorCount;
    public VkDescriptorType descriptorType;
    public nint offset;
    public nint stride;
}