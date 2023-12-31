﻿namespace VulkanNative;

[Flags]
public enum VkBufferUsageFlags2KHR : ulong
{
    VK_BUFFER_USAGE_2_TRANSFER_SRC_BIT_KHR = 1UL << 0,
    VK_BUFFER_USAGE_2_TRANSFER_DST_BIT_KHR = 1UL << 1,
    VK_BUFFER_USAGE_2_UNIFORM_TEXEL_BUFFER_BIT_KHR = 1UL << 2,
    VK_BUFFER_USAGE_2_STORAGE_TEXEL_BUFFER_BIT_KHR = 1UL << 3,
    VK_BUFFER_USAGE_2_UNIFORM_BUFFER_BIT_KHR = 1UL << 4,
    VK_BUFFER_USAGE_2_STORAGE_BUFFER_BIT_KHR = 1UL << 5,
    VK_BUFFER_USAGE_2_INDEX_BUFFER_BIT_KHR = 1UL << 6,
    VK_BUFFER_USAGE_2_VERTEX_BUFFER_BIT_KHR = 1UL << 7,
    VK_BUFFER_USAGE_2_INDIRECT_BUFFER_BIT_KHR = 1UL << 8,
    VK_BUFFER_USAGE_2_CONDITIONAL_RENDERING_BIT_EXT = 1UL << 9,
    VK_BUFFER_USAGE_2_SHADER_BINDING_TABLE_BIT_KHR = 1UL << 10,
    VK_BUFFER_USAGE_2_TRANSFORM_FEEDBACK_BUFFER_BIT_EXT = 1UL << 11,
    VK_BUFFER_USAGE_2_TRANSFORM_FEEDBACK_COUNTER_BUFFER_BIT_EXT = 1UL << 12,
    VK_BUFFER_USAGE_2_VIDEO_DECODE_SRC_BIT_KHR = 1UL << 13,
    VK_BUFFER_USAGE_2_VIDEO_DECODE_DST_BIT_KHR = 1UL << 14,
    VK_BUFFER_USAGE_2_VIDEO_ENCODE_DST_BIT_KHR = 1UL << 15,
    VK_BUFFER_USAGE_2_VIDEO_ENCODE_SRC_BIT_KHR = 1UL << 16,
    VK_BUFFER_USAGE_2_SHADER_DEVICE_ADDRESS_BIT_KHR = 1UL << 17,
    VK_BUFFER_USAGE_2_ACCELERATION_STRUCTURE_BUILD_INPUT_READ_ONLY_BIT_KHR = 1UL << 19,
    VK_BUFFER_USAGE_2_ACCELERATION_STRUCTURE_STORAGE_BIT_KHR = 1UL << 20,
    VK_BUFFER_USAGE_2_SAMPLER_DESCRIPTOR_BUFFER_BIT_EXT = 1UL << 21,
    VK_BUFFER_USAGE_2_RESOURCE_DESCRIPTOR_BUFFER_BIT_EXT = 1UL << 22,
    VK_BUFFER_USAGE_2_PUSH_DESCRIPTORS_DESCRIPTOR_BUFFER_BIT_EXT = 1UL << 26,
    VK_BUFFER_USAGE_2_MICROMAP_BUILD_INPUT_READ_ONLY_BIT_EXT = 1UL << 23,
    VK_BUFFER_USAGE_2_MICROMAP_STORAGE_BIT_EXT = 1UL << 24
}