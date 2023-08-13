﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceShaderCorePropertiesARM
{
    public VkStructureType SType;
    public void* PNext;
    public uint PixelRate;
    public uint TexelRate;
    public uint FmaRate;
}