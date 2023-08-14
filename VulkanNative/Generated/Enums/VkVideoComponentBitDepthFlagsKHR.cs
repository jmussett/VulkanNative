﻿namespace VulkanNative;

[Flags]
public enum VkVideoComponentBitDepthFlagsKHR : uint
{
    VK_VIDEO_COMPONENT_BIT_DEPTH_INVALID_KHR = 0,
    VK_VIDEO_COMPONENT_BIT_DEPTH_8_BIT_KHR = 1U << 0,
    VK_VIDEO_COMPONENT_BIT_DEPTH_10_BIT_KHR = 1U << 2,
    VK_VIDEO_COMPONENT_BIT_DEPTH_12_BIT_KHR = 1U << 4
}