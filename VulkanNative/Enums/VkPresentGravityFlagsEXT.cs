namespace VulkanNative;

[Flags]
public enum VkPresentGravityFlagsEXT : uint
{
    VK_PRESENT_GRAVITY_MIN_BIT_EXT = 1U << 0,
    VK_PRESENT_GRAVITY_MAX_BIT_EXT = 1U << 1,
    VK_PRESENT_GRAVITY_CENTERED_BIT_EXT = 1U << 2
}