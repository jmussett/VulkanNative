using VulkanNative.Examples.Common.Utility;

namespace VulkanNative.Examples.Common;

public sealed class ShaderStage
{
    public VkPipelineShaderStageCreateFlags Flags { get; set; }
    public required string Name { get; set; }
    public required VkShaderStageFlags Stage { get; set; }
    public required ShaderModule Module { get; set; }
    public SpecializationInfo? SpecializationInfo { get; set; }
}
