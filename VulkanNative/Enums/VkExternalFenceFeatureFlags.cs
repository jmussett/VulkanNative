namespace VulkanNative;

[Flags]
public enum VkExternalFenceFeatureFlags : uint
{
    VK_EXTERNAL_FENCE_FEATURE_EXPORTABLE_BIT = 1U << 0,
    VK_EXTERNAL_FENCE_FEATURE_IMPORTABLE_BIT = 1U << 1
}