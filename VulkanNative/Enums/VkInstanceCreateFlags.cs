namespace VulkanNative;

[Flags]
public enum VkInstanceCreateFlags : uint
{
    VK_INSTANCE_CREATE_ENUMERATE_PORTABILITY_BIT_KHR = 1U << 0
}