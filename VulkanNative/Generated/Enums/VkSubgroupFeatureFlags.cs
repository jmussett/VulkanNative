﻿namespace VulkanNative;

[Flags]
public enum VkSubgroupFeatureFlags : uint
{
    VK_SUBGROUP_FEATURE_BASIC_BIT = 1U << 0,
    VK_SUBGROUP_FEATURE_VOTE_BIT = 1U << 1,
    VK_SUBGROUP_FEATURE_ARITHMETIC_BIT = 1U << 2,
    VK_SUBGROUP_FEATURE_BALLOT_BIT = 1U << 3,
    VK_SUBGROUP_FEATURE_SHUFFLE_BIT = 1U << 4,
    VK_SUBGROUP_FEATURE_SHUFFLE_RELATIVE_BIT = 1U << 5,
    VK_SUBGROUP_FEATURE_CLUSTERED_BIT = 1U << 6,
    VK_SUBGROUP_FEATURE_QUAD_BIT = 1U << 7,
    VK_SUBGROUP_FEATURE_PARTITIONED_BIT_NV = 1U << 8
}