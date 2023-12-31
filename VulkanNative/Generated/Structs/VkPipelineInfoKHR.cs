﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkPipeline pipeline;

    public VkPipelineInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_INFO_KHR;
    }
}