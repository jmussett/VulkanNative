﻿namespace VulkanNative;

[Flags]
public enum VkImageUsageFlags : uint
{
    VK_IMAGE_USAGE_TRANSFER_SRC_BIT = 1U << 0,
    VK_IMAGE_USAGE_TRANSFER_DST_BIT = 1U << 1,
    VK_IMAGE_USAGE_SAMPLED_BIT = 1U << 2,
    VK_IMAGE_USAGE_STORAGE_BIT = 1U << 3,
    VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT = 1U << 4,
    VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT = 1U << 5,
    VK_IMAGE_USAGE_TRANSIENT_ATTACHMENT_BIT = 1U << 6,
    VK_IMAGE_USAGE_INPUT_ATTACHMENT_BIT = 1U << 7
}