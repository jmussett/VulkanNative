namespace VulkanNative;

[Flags]
public enum VkFramebufferCreateFlags : uint
{
    VK_FRAMEBUFFER_CREATE_IMAGELESS_BIT = 1U << 0
}