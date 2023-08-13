namespace VulkanNative;

[Flags]
public enum VkPipelineLayoutCreateFlags : uint
{
    VK_PIPELINE_LAYOUT_CREATE_INDEPENDENT_SETS_BIT_EXT = 1U << 1
}