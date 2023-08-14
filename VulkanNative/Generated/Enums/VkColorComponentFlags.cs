namespace VulkanNative;

[Flags]
public enum VkColorComponentFlags : uint
{
    VK_COLOR_COMPONENT_R_BIT = 1U << 0,
    VK_COLOR_COMPONENT_G_BIT = 1U << 1,
    VK_COLOR_COMPONENT_B_BIT = 1U << 2,
    VK_COLOR_COMPONENT_A_BIT = 1U << 3
}