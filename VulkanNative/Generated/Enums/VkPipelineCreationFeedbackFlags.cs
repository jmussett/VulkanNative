﻿namespace VulkanNative;

[Flags]
public enum VkPipelineCreationFeedbackFlags : uint
{
    VK_PIPELINE_CREATION_FEEDBACK_VALID_BIT = 1U << 0,
    VK_PIPELINE_CREATION_FEEDBACK_APPLICATION_PIPELINE_CACHE_HIT_BIT = 1U << 1,
    VK_PIPELINE_CREATION_FEEDBACK_BASE_PIPELINE_ACCELERATION_BIT = 1U << 2
}