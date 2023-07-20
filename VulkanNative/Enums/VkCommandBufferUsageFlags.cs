﻿namespace VulkanNative;

[Flags]
public enum VkCommandBufferUsageFlags : uint
{
    VK_COMMAND_BUFFER_USAGE_ONE_TIME_SUBMIT_BIT = 1U << 0,
    VK_COMMAND_BUFFER_USAGE_RENDER_PASS_CONTINUE_BIT = 1U << 1,
    VK_COMMAND_BUFFER_USAGE_SIMULTANEOUS_USE_BIT = 1U << 2
}