namespace VulkanNative;

[Flags]
public enum VkQueryResultFlags : uint
{
    VK_QUERY_RESULT_64_BIT = 1U << 0,
    VK_QUERY_RESULT_WAIT_BIT = 1U << 1,
    VK_QUERY_RESULT_WITH_AVAILABILITY_BIT = 1U << 2,
    VK_QUERY_RESULT_PARTIAL_BIT = 1U << 3
}