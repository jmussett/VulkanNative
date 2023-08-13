namespace VulkanNative;

[Flags]
public enum VkPresentScalingFlagsEXT : uint
{
    VK_PRESENT_SCALING_ONE_TO_ONE_BIT_EXT = 1U << 0,
    VK_PRESENT_SCALING_ASPECT_RATIO_STRETCH_BIT_EXT = 1U << 1,
    VK_PRESENT_SCALING_STRETCH_BIT_EXT = 1U << 2
}