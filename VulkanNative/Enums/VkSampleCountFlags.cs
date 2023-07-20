namespace VulkanNative;

[Flags]
public enum VkSampleCountFlags : uint
{
    VK_SAMPLE_COUNT_1_BIT = 1U << 0,
    VK_SAMPLE_COUNT_2_BIT = 1U << 1,
    VK_SAMPLE_COUNT_4_BIT = 1U << 2,
    VK_SAMPLE_COUNT_8_BIT = 1U << 3,
    VK_SAMPLE_COUNT_16_BIT = 1U << 4,
    VK_SAMPLE_COUNT_32_BIT = 1U << 5,
    VK_SAMPLE_COUNT_64_BIT = 1U << 6
}