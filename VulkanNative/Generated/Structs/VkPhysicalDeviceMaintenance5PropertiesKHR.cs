﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceMaintenance5PropertiesKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 earlyFragmentMultisampleCoverageAfterSampleCounting;
    public VkBool32 earlyFragmentSampleMaskTestBeforeSampleCounting;
    public VkBool32 depthStencilSwizzleOneSupport;
    public VkBool32 polygonModePointSize;
    public VkBool32 nonStrictSinglePixelWideLinesUseParallelogram;
    public VkBool32 nonStrictWideLinesUseParallelogram;
}