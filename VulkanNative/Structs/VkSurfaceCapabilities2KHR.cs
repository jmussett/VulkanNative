﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSurfaceCapabilities2KHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkSurfaceCapabilitiesKHR SurfaceCapabilities;
}