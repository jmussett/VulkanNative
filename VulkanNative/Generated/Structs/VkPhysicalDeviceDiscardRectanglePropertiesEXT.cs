﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceDiscardRectanglePropertiesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public uint maxDiscardRectangles;
}