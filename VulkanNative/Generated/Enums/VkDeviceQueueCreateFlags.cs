namespace VulkanNative;

[Flags]
public enum VkDeviceQueueCreateFlags : uint
{
    VK_DEVICE_QUEUE_CREATE_PROTECTED_BIT = 1U << 0
}