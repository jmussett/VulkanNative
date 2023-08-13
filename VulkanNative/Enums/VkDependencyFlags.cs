namespace VulkanNative;

[Flags]
public enum VkDependencyFlags : uint
{
    VK_DEPENDENCY_BY_REGION_BIT = 1U << 0,
    VK_DEPENDENCY_DEVICE_GROUP_BIT = 1U << 2,
    VK_DEPENDENCY_VIEW_LOCAL_BIT = 1U << 1
}