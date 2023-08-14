namespace VulkanNative;

[Flags]
public enum VkSemaphoreImportFlags : uint
{
    VK_SEMAPHORE_IMPORT_TEMPORARY_BIT = 1U << 0
}