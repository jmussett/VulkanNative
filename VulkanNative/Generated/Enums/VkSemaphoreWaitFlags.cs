namespace VulkanNative;

[Flags]
public enum VkSemaphoreWaitFlags : uint
{
    VK_SEMAPHORE_WAIT_ANY_BIT = 1U << 0
}