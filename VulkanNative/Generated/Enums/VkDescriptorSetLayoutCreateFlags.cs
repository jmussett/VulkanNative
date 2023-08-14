﻿namespace VulkanNative;

[Flags]
public enum VkDescriptorSetLayoutCreateFlags : uint
{
    VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT = 1U << 1,
    VK_DESCRIPTOR_SET_LAYOUT_CREATE_PUSH_DESCRIPTOR_BIT_KHR = 1U << 0,
    VK_DESCRIPTOR_SET_LAYOUT_CREATE_DESCRIPTOR_BUFFER_BIT_EXT = 1U << 4,
    VK_DESCRIPTOR_SET_LAYOUT_CREATE_EMBEDDED_IMMUTABLE_SAMPLERS_BIT_EXT = 1U << 5,
    VK_DESCRIPTOR_SET_LAYOUT_CREATE_INDIRECT_BINDABLE_BIT_NV = 1U << 7,
    VK_DESCRIPTOR_SET_LAYOUT_CREATE_HOST_ONLY_POOL_BIT_EXT = 1U << 2
}