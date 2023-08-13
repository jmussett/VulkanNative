namespace VulkanNative;

[Flags]
public enum VkPipelineShaderStageCreateFlags : uint
{
    VK_PIPELINE_SHADER_STAGE_CREATE_ALLOW_VARYING_SUBGROUP_SIZE_BIT = 1U << 0,
    VK_PIPELINE_SHADER_STAGE_CREATE_REQUIRE_FULL_SUBGROUPS_BIT = 1U << 1
}