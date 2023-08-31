﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkFormatProperties3
{
    public VkStructureType sType;
    public void* pNext;
    public VkFormatFeatureFlags2 linearTilingFeatures;
    public VkFormatFeatureFlags2 optimalTilingFeatures;
    public VkFormatFeatureFlags2 bufferFeatures;
}