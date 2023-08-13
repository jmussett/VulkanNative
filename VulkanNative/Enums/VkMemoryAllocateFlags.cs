namespace VulkanNative;

[Flags]
public enum VkMemoryAllocateFlags : uint
{
    VK_MEMORY_ALLOCATE_DEVICE_MASK_BIT = 1U << 0,
    VK_MEMORY_ALLOCATE_DEVICE_ADDRESS_BIT = 1U << 1,
    VK_MEMORY_ALLOCATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT = 1U << 2
}