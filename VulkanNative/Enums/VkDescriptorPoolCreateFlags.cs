namespace VulkanNative;

[Flags]
public enum VkDescriptorPoolCreateFlags : uint
{
    VK_DESCRIPTOR_POOL_CREATE_FREE_DESCRIPTOR_SET_BIT = 1U << 0,
    VK_DESCRIPTOR_POOL_CREATE_UPDATE_AFTER_BIND_BIT = 1U << 1
}