namespace VulkanNative;

[Flags]
public enum VkMemoryHeapFlags : uint
{
    VK_MEMORY_HEAP_DEVICE_LOCAL_BIT = 1U << 0,
    VK_MEMORY_HEAP_MULTI_INSTANCE_BIT = 1U << 1
}