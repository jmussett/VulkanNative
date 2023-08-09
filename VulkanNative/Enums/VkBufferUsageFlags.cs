﻿namespace VulkanNative;

[Flags]
public enum VkBufferUsageFlags : uint
{
    VK_BUFFER_USAGE_TRANSFER_SRC_BIT = 1U << 0,
    VK_BUFFER_USAGE_TRANSFER_DST_BIT = 1U << 1,
    VK_BUFFER_USAGE_UNIFORM_TEXEL_BUFFER_BIT = 1U << 2,
    VK_BUFFER_USAGE_STORAGE_TEXEL_BUFFER_BIT = 1U << 3,
    VK_BUFFER_USAGE_UNIFORM_BUFFER_BIT = 1U << 4,
    VK_BUFFER_USAGE_STORAGE_BUFFER_BIT = 1U << 5,
    VK_BUFFER_USAGE_INDEX_BUFFER_BIT = 1U << 6,
    VK_BUFFER_USAGE_VERTEX_BUFFER_BIT = 1U << 7,
    VK_BUFFER_USAGE_INDIRECT_BUFFER_BIT = 1U << 8
}