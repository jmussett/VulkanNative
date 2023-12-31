﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSamplerBlockMatchWindowCreateInfoQCOM
{
    public VkStructureType sType;
    public void* pNext;
    public VkExtent2D windowExtent;
    public VkBlockMatchWindowCompareModeQCOM windowCompareMode;

    public VkSamplerBlockMatchWindowCreateInfoQCOM()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_SAMPLER_BLOCK_MATCH_WINDOW_CREATE_INFO_QCOM;
    }
}