namespace VulkanNative;

[Flags]
public enum VkGeometryFlagsKHR : uint
{
    VK_GEOMETRY_OPAQUE_BIT_KHR = 1U << 0,
    VK_GEOMETRY_NO_DUPLICATE_ANY_HIT_INVOCATION_BIT_KHR = 1U << 1
}