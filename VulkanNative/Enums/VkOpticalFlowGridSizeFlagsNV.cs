﻿namespace VulkanNative;

[Flags]
public enum VkOpticalFlowGridSizeFlagsNV : uint
{
    VK_OPTICAL_FLOW_GRID_SIZE_UNKNOWN_NV = 0,
    VK_OPTICAL_FLOW_GRID_SIZE_1X1_BIT_NV = 1U << 0,
    VK_OPTICAL_FLOW_GRID_SIZE_2X2_BIT_NV = 1U << 1,
    VK_OPTICAL_FLOW_GRID_SIZE_4X4_BIT_NV = 1U << 2,
    VK_OPTICAL_FLOW_GRID_SIZE_8X8_BIT_NV = 1U << 3
}