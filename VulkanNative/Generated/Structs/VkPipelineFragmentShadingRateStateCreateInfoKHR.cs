﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineFragmentShadingRateStateCreateInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkExtent2D fragmentSize;
    public VkFragmentShadingRateCombinerOpKHR* combinerOps;
}