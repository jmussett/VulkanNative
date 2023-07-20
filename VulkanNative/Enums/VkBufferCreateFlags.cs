namespace VulkanNative;

[Flags]
public enum VkBufferCreateFlags : uint
{
    VK_BUFFER_CREATE_SPARSE_BINDING_BIT = 1U << 0,
    VK_BUFFER_CREATE_SPARSE_RESIDENCY_BIT = 1U << 1,
    VK_BUFFER_CREATE_SPARSE_ALIASED_BIT = 1U << 2
}