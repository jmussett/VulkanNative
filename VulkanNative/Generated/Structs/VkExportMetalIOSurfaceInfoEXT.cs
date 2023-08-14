﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExportMetalIOSurfaceInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkImage Image;
    public IOSurfaceRef IoSurface;
}