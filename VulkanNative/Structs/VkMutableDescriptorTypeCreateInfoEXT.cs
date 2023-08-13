﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMutableDescriptorTypeCreateInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public uint MutableDescriptorTypeListCount;
    public VkMutableDescriptorTypeListEXT* PMutableDescriptorTypeLists;
}