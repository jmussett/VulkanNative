namespace VulkanNative;

[Flags]
public enum VkPipelineCreateFlags : uint
{
    VK_PIPELINE_CREATE_DISABLE_OPTIMIZATION_BIT = 1U << 0,
    VK_PIPELINE_CREATE_ALLOW_DERIVATIVES_BIT = 1U << 1,
    VK_PIPELINE_CREATE_DERIVATIVE_BIT = 1U << 2
}