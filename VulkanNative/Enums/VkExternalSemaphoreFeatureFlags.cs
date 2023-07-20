namespace VulkanNative;

[Flags]
public enum VkExternalSemaphoreFeatureFlags : uint
{
    VK_EXTERNAL_SEMAPHORE_FEATURE_EXPORTABLE_BIT = 1U << 0,
    VK_EXTERNAL_SEMAPHORE_FEATURE_IMPORTABLE_BIT = 1U << 1
}