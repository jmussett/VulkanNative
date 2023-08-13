namespace VulkanNative;

[Flags]
public enum VkEventCreateFlags : uint
{
    VK_EVENT_CREATE_DEVICE_ONLY_BIT = 1U << 0
}