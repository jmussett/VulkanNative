﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSurfaceFormatKHR
{
    public VkFormat format;
    public VkColorSpaceKHR colorSpace;
}