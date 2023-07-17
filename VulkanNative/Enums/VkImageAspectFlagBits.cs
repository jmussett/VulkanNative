namespace VulkanNative;

[Flags]
public enum VkImageAspectFlagBits : uint
{
    VK_IMAGE_ASPECT_COLOR_BIT = 0,
    VK_IMAGE_ASPECT_DEPTH_BIT = 1,
    VK_IMAGE_ASPECT_STENCIL_BIT = 2,
    VK_IMAGE_ASPECT_METADATA_BIT = 3
}