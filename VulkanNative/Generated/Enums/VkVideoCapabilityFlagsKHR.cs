namespace VulkanNative;

[Flags]
public enum VkVideoCapabilityFlagsKHR : uint
{
    VK_VIDEO_CAPABILITY_PROTECTED_CONTENT_BIT_KHR = 1U << 0,
    VK_VIDEO_CAPABILITY_SEPARATE_REFERENCE_IMAGES_BIT_KHR = 1U << 1
}