namespace VulkanNative;

[Flags]
public enum VkPeerMemoryFeatureFlags : uint
{
    VK_PEER_MEMORY_FEATURE_COPY_SRC_BIT = 1U << 0,
    VK_PEER_MEMORY_FEATURE_COPY_DST_BIT = 1U << 1,
    VK_PEER_MEMORY_FEATURE_GENERIC_SRC_BIT = 1U << 2,
    VK_PEER_MEMORY_FEATURE_GENERIC_DST_BIT = 1U << 3
}