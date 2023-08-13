﻿namespace VulkanNative;

[Flags]
public enum VkVideoChromaSubsamplingFlagsKHR : uint
{
    VK_VIDEO_CHROMA_SUBSAMPLING_INVALID_KHR = 0,
    VK_VIDEO_CHROMA_SUBSAMPLING_MONOCHROME_BIT_KHR = 1U << 0,
    VK_VIDEO_CHROMA_SUBSAMPLING_420_BIT_KHR = 1U << 1,
    VK_VIDEO_CHROMA_SUBSAMPLING_422_BIT_KHR = 1U << 2,
    VK_VIDEO_CHROMA_SUBSAMPLING_444_BIT_KHR = 1U << 3
}