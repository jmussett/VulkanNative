namespace VulkanNative;

[Flags]
public enum VkVideoDecodeCapabilityFlagsKHR : uint
{
    VK_VIDEO_DECODE_CAPABILITY_DPB_AND_OUTPUT_COINCIDE_BIT_KHR = 1U << 0,
    VK_VIDEO_DECODE_CAPABILITY_DPB_AND_OUTPUT_DISTINCT_BIT_KHR = 1U << 1
}