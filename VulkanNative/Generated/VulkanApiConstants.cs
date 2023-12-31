﻿namespace VulkanNative;

public static class VulkanApiConstants
{
    public const uint VK_MAX_PHYSICAL_DEVICE_NAME_SIZE = 256;
    public const uint VK_UUID_SIZE = 16;
    public const uint VK_LUID_SIZE = 8;
    public const uint VK_MAX_EXTENSION_NAME_SIZE = 256;
    public const uint VK_MAX_DESCRIPTION_SIZE = 256;
    public const uint VK_MAX_MEMORY_TYPES = 32;
    public const uint VK_MAX_MEMORY_HEAPS = 16;
    public const float VK_LOD_CLAMP_NONE = 1000.0F;
    public const uint VK_REMAINING_MIP_LEVELS = (~0U);
    public const uint VK_REMAINING_ARRAY_LAYERS = (~0U);
    public const uint VK_REMAINING_3D_SLICES_EXT = (~0U);
    public const ulong VK_WHOLE_SIZE = (~0UL);
    public const uint VK_ATTACHMENT_UNUSED = (~0U);
    public const uint VK_TRUE = 1;
    public const uint VK_FALSE = 0;
    public const uint VK_QUEUE_FAMILY_IGNORED = (~0U);
    public const uint VK_QUEUE_FAMILY_EXTERNAL = (~1U);
    public const uint VK_QUEUE_FAMILY_FOREIGN_EXT = (~2U);
    public const uint VK_SUBPASS_EXTERNAL = (~0U);
    public const uint VK_MAX_DEVICE_GROUP_SIZE = 32;
    public const uint VK_MAX_DRIVER_NAME_SIZE = 256;
    public const uint VK_MAX_DRIVER_INFO_SIZE = 256;
    public const uint VK_SHADER_UNUSED_KHR = (~0U);
    public const uint VK_MAX_GLOBAL_PRIORITY_SIZE_KHR = 16;
    public const uint VK_MAX_SHADER_MODULE_IDENTIFIER_SIZE_EXT = 32;
    public const uint VK_SHADER_INDEX_UNUSED_AMDX = (~0U);
}