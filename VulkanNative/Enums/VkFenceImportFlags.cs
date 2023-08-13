namespace VulkanNative;

[Flags]
public enum VkFenceImportFlags : uint
{
    VK_FENCE_IMPORT_TEMPORARY_BIT = 1U << 0
}