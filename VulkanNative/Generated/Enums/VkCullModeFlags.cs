namespace VulkanNative;

[Flags]
public enum VkCullModeFlags : uint
{
    VK_CULL_MODE_NONE = 0,
    VK_CULL_MODE_FRONT_BIT = 1U << 0,
    VK_CULL_MODE_BACK_BIT = 1U << 1,
    VK_CULL_MODE_FRONT_AND_BACK = 0x00000003
}