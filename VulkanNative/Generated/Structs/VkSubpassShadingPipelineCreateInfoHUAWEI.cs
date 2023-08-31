﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSubpassShadingPipelineCreateInfoHUAWEI
{
    public VkStructureType sType;
    public void* pNext;
    public VkRenderPass renderPass;
    public uint subpass;
}