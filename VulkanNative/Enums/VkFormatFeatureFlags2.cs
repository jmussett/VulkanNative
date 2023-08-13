﻿namespace VulkanNative;

[Flags]
public enum VkFormatFeatureFlags2 : ulong
{
    VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_BIT = 1UL << 0,
    VK_FORMAT_FEATURE_2_STORAGE_IMAGE_BIT = 1UL << 1,
    VK_FORMAT_FEATURE_2_STORAGE_IMAGE_ATOMIC_BIT = 1UL << 2,
    VK_FORMAT_FEATURE_2_UNIFORM_TEXEL_BUFFER_BIT = 1UL << 3,
    VK_FORMAT_FEATURE_2_STORAGE_TEXEL_BUFFER_BIT = 1UL << 4,
    VK_FORMAT_FEATURE_2_STORAGE_TEXEL_BUFFER_ATOMIC_BIT = 1UL << 5,
    VK_FORMAT_FEATURE_2_VERTEX_BUFFER_BIT = 1UL << 6,
    VK_FORMAT_FEATURE_2_COLOR_ATTACHMENT_BIT = 1UL << 7,
    VK_FORMAT_FEATURE_2_COLOR_ATTACHMENT_BLEND_BIT = 1UL << 8,
    VK_FORMAT_FEATURE_2_DEPTH_STENCIL_ATTACHMENT_BIT = 1UL << 9,
    VK_FORMAT_FEATURE_2_BLIT_SRC_BIT = 1UL << 10,
    VK_FORMAT_FEATURE_2_BLIT_DST_BIT = 1UL << 11,
    VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_LINEAR_BIT = 1UL << 12,
    VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_CUBIC_BIT = 1UL << 13,
    VK_FORMAT_FEATURE_2_TRANSFER_SRC_BIT = 1UL << 14,
    VK_FORMAT_FEATURE_2_TRANSFER_DST_BIT = 1UL << 15,
    VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_MINMAX_BIT = 1UL << 16,
    VK_FORMAT_FEATURE_2_MIDPOINT_CHROMA_SAMPLES_BIT = 1UL << 17,
    VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_LINEAR_FILTER_BIT = 1UL << 18,
    VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_SEPARATE_RECONSTRUCTION_FILTER_BIT = 1UL << 19,
    VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_BIT = 1UL << 20,
    VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_FORCEABLE_BIT = 1UL << 21,
    VK_FORMAT_FEATURE_2_DISJOINT_BIT = 1UL << 22,
    VK_FORMAT_FEATURE_2_COSITED_CHROMA_SAMPLES_BIT = 1UL << 23,
    VK_FORMAT_FEATURE_2_STORAGE_READ_WITHOUT_FORMAT_BIT = 1UL << 31,
    VK_FORMAT_FEATURE_2_STORAGE_WRITE_WITHOUT_FORMAT_BIT = 1UL << 32,
    VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_DEPTH_COMPARISON_BIT = 1UL << 33
}