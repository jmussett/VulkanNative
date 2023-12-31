﻿namespace VulkanNative;

[Flags]
public enum VkFormatFeatureFlags : uint
{
    VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT = 1U << 0,
    VK_FORMAT_FEATURE_STORAGE_IMAGE_BIT = 1U << 1,
    VK_FORMAT_FEATURE_STORAGE_IMAGE_ATOMIC_BIT = 1U << 2,
    VK_FORMAT_FEATURE_UNIFORM_TEXEL_BUFFER_BIT = 1U << 3,
    VK_FORMAT_FEATURE_STORAGE_TEXEL_BUFFER_BIT = 1U << 4,
    VK_FORMAT_FEATURE_STORAGE_TEXEL_BUFFER_ATOMIC_BIT = 1U << 5,
    VK_FORMAT_FEATURE_VERTEX_BUFFER_BIT = 1U << 6,
    VK_FORMAT_FEATURE_COLOR_ATTACHMENT_BIT = 1U << 7,
    VK_FORMAT_FEATURE_COLOR_ATTACHMENT_BLEND_BIT = 1U << 8,
    VK_FORMAT_FEATURE_DEPTH_STENCIL_ATTACHMENT_BIT = 1U << 9,
    VK_FORMAT_FEATURE_BLIT_SRC_BIT = 1U << 10,
    VK_FORMAT_FEATURE_BLIT_DST_BIT = 1U << 11,
    VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_LINEAR_BIT = 1U << 12,
    VK_FORMAT_FEATURE_TRANSFER_SRC_BIT = 1U << 14,
    VK_FORMAT_FEATURE_TRANSFER_DST_BIT = 1U << 15,
    VK_FORMAT_FEATURE_MIDPOINT_CHROMA_SAMPLES_BIT = 1U << 17,
    VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_LINEAR_FILTER_BIT = 1U << 18,
    VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_SEPARATE_RECONSTRUCTION_FILTER_BIT = 1U << 19,
    VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_BIT = 1U << 20,
    VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_FORCEABLE_BIT = 1U << 21,
    VK_FORMAT_FEATURE_DISJOINT_BIT = 1U << 22,
    VK_FORMAT_FEATURE_COSITED_CHROMA_SAMPLES_BIT = 1U << 23,
    VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_MINMAX_BIT = 1U << 16,
    VK_FORMAT_FEATURE_VIDEO_DECODE_OUTPUT_BIT_KHR = 1U << 25,
    VK_FORMAT_FEATURE_VIDEO_DECODE_DPB_BIT_KHR = 1U << 26,
    VK_FORMAT_FEATURE_ACCELERATION_STRUCTURE_VERTEX_BUFFER_BIT_KHR = 1U << 29,
    VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_CUBIC_BIT_EXT = 1U << 13,
    VK_FORMAT_FEATURE_FRAGMENT_DENSITY_MAP_BIT_EXT = 1U << 24,
    VK_FORMAT_FEATURE_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR = 1U << 30
}