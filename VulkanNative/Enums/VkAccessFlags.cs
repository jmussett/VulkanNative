﻿namespace VulkanNative;

[Flags]
public enum VkAccessFlags : uint
{
    VK_ACCESS_INDIRECT_COMMAND_READ_BIT = 1U << 0,
    VK_ACCESS_INDEX_READ_BIT = 1U << 1,
    VK_ACCESS_VERTEX_ATTRIBUTE_READ_BIT = 1U << 2,
    VK_ACCESS_UNIFORM_READ_BIT = 1U << 3,
    VK_ACCESS_INPUT_ATTACHMENT_READ_BIT = 1U << 4,
    VK_ACCESS_SHADER_READ_BIT = 1U << 5,
    VK_ACCESS_SHADER_WRITE_BIT = 1U << 6,
    VK_ACCESS_COLOR_ATTACHMENT_READ_BIT = 1U << 7,
    VK_ACCESS_COLOR_ATTACHMENT_WRITE_BIT = 1U << 8,
    VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_READ_BIT = 1U << 9,
    VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT = 1U << 10,
    VK_ACCESS_TRANSFER_READ_BIT = 1U << 11,
    VK_ACCESS_TRANSFER_WRITE_BIT = 1U << 12,
    VK_ACCESS_HOST_READ_BIT = 1U << 13,
    VK_ACCESS_HOST_WRITE_BIT = 1U << 14,
    VK_ACCESS_MEMORY_READ_BIT = 1U << 15,
    VK_ACCESS_MEMORY_WRITE_BIT = 1U << 16,
    VK_ACCESS_NONE = 0
}