namespace VulkanNative;

[Flags]
public enum VkQueueFlags : uint
{
    VK_QUEUE_GRAPHICS_BIT = 1U << 0,
    VK_QUEUE_COMPUTE_BIT = 1U << 1,
    VK_QUEUE_TRANSFER_BIT = 1U << 2,
    VK_QUEUE_SPARSE_BINDING_BIT = 1U << 3
}