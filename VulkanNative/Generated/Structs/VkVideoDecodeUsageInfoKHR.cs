﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoDecodeUsageInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkVideoDecodeUsageFlagsKHR videoUsageHints;

    public VkVideoDecodeUsageInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_DECODE_USAGE_INFO_KHR;
    }
}