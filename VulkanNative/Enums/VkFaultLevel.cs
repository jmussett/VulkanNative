namespace VulkanNative;

public enum VkFaultLevel : int
{
    VK_FAULT_LEVEL_UNASSIGNED = 0,
    VK_FAULT_LEVEL_CRITICAL = 1,
    VK_FAULT_LEVEL_RECOVERABLE = 2,
    VK_FAULT_LEVEL_WARNING = 3
}