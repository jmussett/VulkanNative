namespace VulkanNative;

[Flags]
public enum VkExternalMemoryFeatureFlags : uint
{
    VK_EXTERNAL_MEMORY_FEATURE_DEDICATED_ONLY_BIT = 1U << 0,
    VK_EXTERNAL_MEMORY_FEATURE_EXPORTABLE_BIT = 1U << 1,
    VK_EXTERNAL_MEMORY_FEATURE_IMPORTABLE_BIT = 1U << 2
}