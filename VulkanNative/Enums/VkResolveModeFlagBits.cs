namespace VulkanNative;

[Flags]
public enum VkResolveModeFlagBits : uint
{
    VK_RESOLVE_MODE_NONE = 0,
    VK_RESOLVE_MODE_SAMPLE_ZERO_BIT = 0,
    VK_RESOLVE_MODE_AVERAGE_BIT = 1,
    VK_RESOLVE_MODE_MIN_BIT = 2,
    VK_RESOLVE_MODE_MAX_BIT = 3
}