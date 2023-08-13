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
    VK_DYNAMIC_STATE_PRIMITIVE_RESTART_ENABLE = 1000377004
}