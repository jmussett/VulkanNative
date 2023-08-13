namespace VulkanNative;

[Flags]
public enum VkQueueFlags : uint
{
    VK_QUEUE_GRAPHICS_BIT = 1U << 0,
    VK_QUEUE_COMPUTE_BIT = 1U << 1,
    VK_QUEUE_TRANSFER_BIT = 1U << 2,
    VK_QUEUE_SPARSE_BINDING_BIT = 1U << 3,
    VK_QUEUE_PROTECTED_BIT = 1U << 4,
    VK_QUEUE_VIDEO_DECODE_BIT_KHR = 1U << 5,
    VK_QUEUE_OPTICAL_FLOW_BIT_NV = 1U << 8
}