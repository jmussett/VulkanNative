namespace VulkanNative;

[Flags]
public enum VkFenceCreateFlags : uint
{
    VK_FENCE_CREATE_SIGNALED_BIT = 1U << 0
}