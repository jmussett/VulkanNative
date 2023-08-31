﻿namespace VulkanNative;

public enum VkQueryType : int
{
    VK_QUERY_TYPE_OCCLUSION = 0,
    VK_QUERY_TYPE_PIPELINE_STATISTICS = 1,
    VK_QUERY_TYPE_TIMESTAMP = 2,
    VK_QUERY_TYPE_RESULT_STATUS_ONLY_KHR = 1000023000,
    VK_QUERY_TYPE_TRANSFORM_FEEDBACK_STREAM_EXT = 1000028004,
    VK_QUERY_TYPE_PERFORMANCE_QUERY_KHR = 1000116000,
    VK_QUERY_TYPE_ACCELERATION_STRUCTURE_COMPACTED_SIZE_KHR = 1000150000,
    VK_QUERY_TYPE_ACCELERATION_STRUCTURE_SERIALIZATION_SIZE_KHR = 1000150001,
    VK_QUERY_TYPE_ACCELERATION_STRUCTURE_COMPACTED_SIZE_NV = 1000165000,
    VK_QUERY_TYPE_PERFORMANCE_QUERY_INTEL = 1000210000,
    VK_QUERY_TYPE_MESH_PRIMITIVES_GENERATED_EXT = 1000328000,
    VK_QUERY_TYPE_PRIMITIVES_GENERATED_EXT = 1000382000,
    VK_QUERY_TYPE_ACCELERATION_STRUCTURE_SERIALIZATION_BOTTOM_LEVEL_POINTERS_KHR = 1000386000,
    VK_QUERY_TYPE_ACCELERATION_STRUCTURE_SIZE_KHR = 1000386001,
    VK_QUERY_TYPE_MICROMAP_SERIALIZATION_SIZE_EXT = 1000396000,
    VK_QUERY_TYPE_MICROMAP_COMPACTED_SIZE_EXT = 1000396001
}