﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSetStateFlagsIndirectCommandNV
{
    public uint data;
}