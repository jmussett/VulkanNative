namespace VulkanNative;

[Flags]
public enum VkCommandBufferResetFlags : uint
{
    VK_COMMAND_BUFFER_RESET_RELEASE_RESOURCES_BIT = 1U << 0
}