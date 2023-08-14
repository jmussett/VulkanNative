﻿namespace VulkanNative;

[Flags]
public enum VkRenderingFlags : uint
{
    VK_RENDERING_CONTENTS_SECONDARY_COMMAND_BUFFERS_BIT = 1U << 0,
    VK_RENDERING_SUSPENDING_BIT = 1U << 1,
    VK_RENDERING_RESUMING_BIT = 1U << 2,
    VK_RENDERING_ENABLE_LEGACY_DITHERING_BIT_EXT = 1U << 3
}