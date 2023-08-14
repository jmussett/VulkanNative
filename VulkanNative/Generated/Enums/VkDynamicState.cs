﻿namespace VulkanNative;

public enum VkDynamicState : int
{
    VK_DYNAMIC_STATE_VIEWPORT = 0,
    VK_DYNAMIC_STATE_SCISSOR = 1,
    VK_DYNAMIC_STATE_LINE_WIDTH = 2,
    VK_DYNAMIC_STATE_DEPTH_BIAS = 3,
    VK_DYNAMIC_STATE_BLEND_CONSTANTS = 4,
    VK_DYNAMIC_STATE_DEPTH_BOUNDS = 5,
    VK_DYNAMIC_STATE_STENCIL_COMPARE_MASK = 6,
    VK_DYNAMIC_STATE_STENCIL_WRITE_MASK = 7,
    VK_DYNAMIC_STATE_STENCIL_REFERENCE = 8,
    VK_DYNAMIC_STATE_CULL_MODE = 1000267000,
    VK_DYNAMIC_STATE_FRONT_FACE = 1000267001,
    VK_DYNAMIC_STATE_PRIMITIVE_TOPOLOGY = 1000267002,
    VK_DYNAMIC_STATE_VIEWPORT_WITH_COUNT = 1000267003,
    VK_DYNAMIC_STATE_SCISSOR_WITH_COUNT = 1000267004,
    VK_DYNAMIC_STATE_VERTEX_INPUT_BINDING_STRIDE = 1000267005,
    VK_DYNAMIC_STATE_DEPTH_TEST_ENABLE = 1000267006,
    VK_DYNAMIC_STATE_DEPTH_WRITE_ENABLE = 1000267007,
    VK_DYNAMIC_STATE_DEPTH_COMPARE_OP = 1000267008,
    VK_DYNAMIC_STATE_DEPTH_BOUNDS_TEST_ENABLE = 1000267009,
    VK_DYNAMIC_STATE_STENCIL_TEST_ENABLE = 1000267010,
    VK_DYNAMIC_STATE_STENCIL_OP = 1000267011,
    VK_DYNAMIC_STATE_RASTERIZER_DISCARD_ENABLE = 1000377001,
    VK_DYNAMIC_STATE_DEPTH_BIAS_ENABLE = 1000377002,
    VK_DYNAMIC_STATE_PRIMITIVE_RESTART_ENABLE = 1000377004,
    VK_DYNAMIC_STATE_VIEWPORT_W_SCALING_NV = 1000524000,
    VK_DYNAMIC_STATE_DISCARD_RECTANGLE_EXT = 1000524000,
    VK_DYNAMIC_STATE_DISCARD_RECTANGLE_ENABLE_EXT = 1000524001,
    VK_DYNAMIC_STATE_DISCARD_RECTANGLE_MODE_EXT = 1000524002,
    VK_DYNAMIC_STATE_SAMPLE_LOCATIONS_EXT = 1000524000,
    VK_DYNAMIC_STATE_RAY_TRACING_PIPELINE_STACK_SIZE_KHR = 1000524000,
    VK_DYNAMIC_STATE_VIEWPORT_SHADING_RATE_PALETTE_NV = 1000524004,
    VK_DYNAMIC_STATE_VIEWPORT_COARSE_SAMPLE_ORDER_NV = 1000524006,
    VK_DYNAMIC_STATE_EXCLUSIVE_SCISSOR_ENABLE_NV = 1000524000,
    VK_DYNAMIC_STATE_EXCLUSIVE_SCISSOR_NV = 1000524001,
    VK_DYNAMIC_STATE_FRAGMENT_SHADING_RATE_KHR = 1000524000,
    VK_DYNAMIC_STATE_LINE_STIPPLE_EXT = 1000524000,
    VK_DYNAMIC_STATE_VERTEX_INPUT_EXT = 1000524000,
    VK_DYNAMIC_STATE_PATCH_CONTROL_POINTS_EXT = 1000524000,
    VK_DYNAMIC_STATE_LOGIC_OP_EXT = 1000524003,
    VK_DYNAMIC_STATE_COLOR_WRITE_ENABLE_EXT = 1000524000,
    VK_DYNAMIC_STATE_TESSELLATION_DOMAIN_ORIGIN_EXT = 1000524002,
    VK_DYNAMIC_STATE_DEPTH_CLAMP_ENABLE_EXT = 1000524003,
    VK_DYNAMIC_STATE_POLYGON_MODE_EXT = 1000524004,
    VK_DYNAMIC_STATE_RASTERIZATION_SAMPLES_EXT = 1000524005,
    VK_DYNAMIC_STATE_SAMPLE_MASK_EXT = 1000524006,
    VK_DYNAMIC_STATE_ALPHA_TO_COVERAGE_ENABLE_EXT = 1000524007,
    VK_DYNAMIC_STATE_ALPHA_TO_ONE_ENABLE_EXT = 1000524008,
    VK_DYNAMIC_STATE_LOGIC_OP_ENABLE_EXT = 1000524009,
    VK_DYNAMIC_STATE_COLOR_BLEND_ENABLE_EXT = 1000524010,
    VK_DYNAMIC_STATE_COLOR_BLEND_EQUATION_EXT = 1000524011,
    VK_DYNAMIC_STATE_COLOR_WRITE_MASK_EXT = 1000524012,
    VK_DYNAMIC_STATE_RASTERIZATION_STREAM_EXT = 1000524013,
    VK_DYNAMIC_STATE_CONSERVATIVE_RASTERIZATION_MODE_EXT = 1000524014,
    VK_DYNAMIC_STATE_EXTRA_PRIMITIVE_OVERESTIMATION_SIZE_EXT = 1000524015,
    VK_DYNAMIC_STATE_DEPTH_CLIP_ENABLE_EXT = 1000524016,
    VK_DYNAMIC_STATE_SAMPLE_LOCATIONS_ENABLE_EXT = 1000524017,
    VK_DYNAMIC_STATE_COLOR_BLEND_ADVANCED_EXT = 1000524018,
    VK_DYNAMIC_STATE_PROVOKING_VERTEX_MODE_EXT = 1000524019,
    VK_DYNAMIC_STATE_LINE_RASTERIZATION_MODE_EXT = 1000524020,
    VK_DYNAMIC_STATE_LINE_STIPPLE_ENABLE_EXT = 1000524021,
    VK_DYNAMIC_STATE_DEPTH_CLIP_NEGATIVE_ONE_TO_ONE_EXT = 1000524022,
    VK_DYNAMIC_STATE_VIEWPORT_W_SCALING_ENABLE_NV = 1000524023,
    VK_DYNAMIC_STATE_VIEWPORT_SWIZZLE_NV = 1000524024,
    VK_DYNAMIC_STATE_COVERAGE_TO_COLOR_ENABLE_NV = 1000524025,
    VK_DYNAMIC_STATE_COVERAGE_TO_COLOR_LOCATION_NV = 1000524026,
    VK_DYNAMIC_STATE_COVERAGE_MODULATION_MODE_NV = 1000524027,
    VK_DYNAMIC_STATE_COVERAGE_MODULATION_TABLE_ENABLE_NV = 1000524028,
    VK_DYNAMIC_STATE_COVERAGE_MODULATION_TABLE_NV = 1000524029,
    VK_DYNAMIC_STATE_SHADING_RATE_IMAGE_ENABLE_NV = 1000524030,
    VK_DYNAMIC_STATE_REPRESENTATIVE_FRAGMENT_TEST_ENABLE_NV = 1000524031,
    VK_DYNAMIC_STATE_COVERAGE_REDUCTION_MODE_NV = 1000524032,
    VK_DYNAMIC_STATE_ATTACHMENT_FEEDBACK_LOOP_ENABLE_EXT = 1000524000
}