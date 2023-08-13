﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceProtectedMemoryFeatures
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 protectedMemory;
}