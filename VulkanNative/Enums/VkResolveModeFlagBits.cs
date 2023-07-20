namespace VulkanNative;

[Flags]
public enum VkResolveModeFlagBits : uint
{
    VK_RESOLVE_MODE_NONE = 0,
    VK_RESOLVE_MODE_SAMPLE_ZERO_BIT = 1U << 0,
    VK_RESOLVE_MODE_AVERAGE_BIT = 1U << 1,
    VK_RESOLVE_MODE_MIN_BIT = 1U << 2,
    VK_RESOLVE_MODE_MAX_BIT = 1U << 3
}