namespace VulkanNative;

[Flags]
public enum VkImageAspectFlags : uint
{
    VK_IMAGE_ASPECT_COLOR_BIT = 1U << 0,
    VK_IMAGE_ASPECT_DEPTH_BIT = 1U << 1,
    VK_IMAGE_ASPECT_STENCIL_BIT = 1U << 2,
    VK_IMAGE_ASPECT_METADATA_BIT = 1U << 3
}