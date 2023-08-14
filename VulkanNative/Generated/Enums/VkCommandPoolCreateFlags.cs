namespace VulkanNative;

[Flags]
public enum VkCommandPoolCreateFlags : uint
{
    VK_COMMAND_POOL_CREATE_TRANSIENT_BIT = 1U << 0,
    VK_COMMAND_POOL_CREATE_RESET_COMMAND_BUFFER_BIT = 1U << 1,
    VK_COMMAND_POOL_CREATE_PROTECTED_BIT = 1U << 2
}