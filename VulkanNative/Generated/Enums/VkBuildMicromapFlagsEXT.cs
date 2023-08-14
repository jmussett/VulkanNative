namespace VulkanNative;

[Flags]
public enum VkBuildMicromapFlagsEXT : uint
{
    VK_BUILD_MICROMAP_PREFER_FAST_TRACE_BIT_EXT = 1U << 0,
    VK_BUILD_MICROMAP_PREFER_FAST_BUILD_BIT_EXT = 1U << 1,
    VK_BUILD_MICROMAP_ALLOW_COMPACTION_BIT_EXT = 1U << 2
}