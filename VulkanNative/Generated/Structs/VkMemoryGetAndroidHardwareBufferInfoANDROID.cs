﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMemoryGetAndroidHardwareBufferInfoANDROID
{
    public VkStructureType sType;
    public void* pNext;
    public VkDeviceMemory memory;
}