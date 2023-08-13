﻿namespace VulkanNative;

[Flags]
public enum VkPipelineDepthStencilStateCreateFlags : uint
{
    VK_PIPELINE_DEPTH_STENCIL_STATE_CREATE_RASTERIZATION_ORDER_ATTACHMENT_DEPTH_ACCESS_BIT_EXT = 1U << 0,
    VK_PIPELINE_DEPTH_STENCIL_STATE_CREATE_RASTERIZATION_ORDER_ATTACHMENT_STENCIL_ACCESS_BIT_EXT = 1U << 1
}