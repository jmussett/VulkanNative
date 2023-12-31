﻿namespace VulkanNative;

[Flags]
public enum VkGeometryInstanceFlagsKHR : uint
{
    VK_GEOMETRY_INSTANCE_TRIANGLE_FACING_CULL_DISABLE_BIT_KHR = 1U << 0,
    VK_GEOMETRY_INSTANCE_TRIANGLE_FLIP_FACING_BIT_KHR = 1U << 1,
    VK_GEOMETRY_INSTANCE_FORCE_OPAQUE_BIT_KHR = 1U << 2,
    VK_GEOMETRY_INSTANCE_FORCE_NO_OPAQUE_BIT_KHR = 1U << 3,
    VK_GEOMETRY_INSTANCE_FORCE_OPACITY_MICROMAP_2_STATE_EXT = 1U << 4,
    VK_GEOMETRY_INSTANCE_DISABLE_OPACITY_MICROMAPS_EXT = 1U << 5
}