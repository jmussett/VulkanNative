﻿namespace VulkanNative;

[Flags]
public enum VkPipelineStageFlags : uint
{
    VK_PIPELINE_STAGE_TOP_OF_PIPE_BIT = 1U << 0,
    VK_PIPELINE_STAGE_DRAW_INDIRECT_BIT = 1U << 1,
    VK_PIPELINE_STAGE_VERTEX_INPUT_BIT = 1U << 2,
    VK_PIPELINE_STAGE_VERTEX_SHADER_BIT = 1U << 3,
    VK_PIPELINE_STAGE_TESSELLATION_CONTROL_SHADER_BIT = 1U << 4,
    VK_PIPELINE_STAGE_TESSELLATION_EVALUATION_SHADER_BIT = 1U << 5,
    VK_PIPELINE_STAGE_GEOMETRY_SHADER_BIT = 1U << 6,
    VK_PIPELINE_STAGE_FRAGMENT_SHADER_BIT = 1U << 7,
    VK_PIPELINE_STAGE_EARLY_FRAGMENT_TESTS_BIT = 1U << 8,
    VK_PIPELINE_STAGE_LATE_FRAGMENT_TESTS_BIT = 1U << 9,
    VK_PIPELINE_STAGE_COLOR_ATTACHMENT_OUTPUT_BIT = 1U << 10,
    VK_PIPELINE_STAGE_COMPUTE_SHADER_BIT = 1U << 11,
    VK_PIPELINE_STAGE_TRANSFER_BIT = 1U << 12,
    VK_PIPELINE_STAGE_BOTTOM_OF_PIPE_BIT = 1U << 13,
    VK_PIPELINE_STAGE_HOST_BIT = 1U << 14,
    VK_PIPELINE_STAGE_ALL_GRAPHICS_BIT = 1U << 15,
    VK_PIPELINE_STAGE_ALL_COMMANDS_BIT = 1U << 16,
    VK_PIPELINE_STAGE_NONE = 0,
    VK_PIPELINE_STAGE_TRANSFORM_FEEDBACK_BIT_EXT = 1U << 24,
    VK_PIPELINE_STAGE_CONDITIONAL_RENDERING_BIT_EXT = 1U << 18,
    VK_PIPELINE_STAGE_ACCELERATION_STRUCTURE_BUILD_BIT_KHR = 1U << 25,
    VK_PIPELINE_STAGE_RAY_TRACING_SHADER_BIT_KHR = 1U << 21,
    VK_PIPELINE_STAGE_FRAGMENT_DENSITY_PROCESS_BIT_EXT = 1U << 23,
    VK_PIPELINE_STAGE_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR = 1U << 22,
    VK_PIPELINE_STAGE_COMMAND_PREPROCESS_BIT_NV = 1U << 17,
    VK_PIPELINE_STAGE_TASK_SHADER_BIT_EXT = 1U << 19,
    VK_PIPELINE_STAGE_MESH_SHADER_BIT_EXT = 1U << 20
}