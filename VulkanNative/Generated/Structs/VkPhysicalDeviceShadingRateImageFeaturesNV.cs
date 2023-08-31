﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceShadingRateImageFeaturesNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 shadingRateImage;
    public VkBool32 shadingRateCoarseSampleOrder;
}