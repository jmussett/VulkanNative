namespace VulkanNative;

[Flags]
public enum VkCommandPoolResetFlags : uint
{
    VK_COMMAND_POOL_RESET_RELEASE_RESOURCES_BIT = 1U << 0
}