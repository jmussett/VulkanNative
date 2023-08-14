﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExportFenceWin32HandleInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public nint* PAttributes;
    public nint DwAccess;
    public nint Name;
}