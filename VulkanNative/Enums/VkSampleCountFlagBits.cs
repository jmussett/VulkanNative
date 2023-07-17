namespace VulkanNative;

[Flags]
public enum VkSampleCountFlagBits : uint
{
    VK_SAMPLE_COUNT_1_BIT = 0,
    VK_SAMPLE_COUNT_2_BIT = 1,
    VK_SAMPLE_COUNT_4_BIT = 2,
    VK_SAMPLE_COUNT_8_BIT = 3,
    VK_SAMPLE_COUNT_16_BIT = 4,
    VK_SAMPLE_COUNT_32_BIT = 5,
    VK_SAMPLE_COUNT_64_BIT = 6
}