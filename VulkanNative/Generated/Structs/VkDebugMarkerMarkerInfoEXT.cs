﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDebugMarkerMarkerInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public byte* PMarkerName;
    public fixed float Color[4];
}