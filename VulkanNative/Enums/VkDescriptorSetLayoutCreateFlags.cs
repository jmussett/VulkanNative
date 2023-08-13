namespace VulkanNative;

[Flags]
public enum VkDescriptorSetLayoutCreateFlags : uint
{
    VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT = 1U << 1
}