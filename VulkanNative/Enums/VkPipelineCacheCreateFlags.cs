namespace VulkanNative;

[Flags]
public enum VkPipelineCacheCreateFlags : uint
{
    VK_PIPELINE_CACHE_CREATE_EXTERNALLY_SYNCHRONIZED_BIT = 1U << 0
}