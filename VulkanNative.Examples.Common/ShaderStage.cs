using VulkanNative.Examples.Common.Utility;

namespace VulkanNative.Examples.Common;

public sealed class ShaderStage : IDisposable
{
    public VkPipelineShaderStageCreateFlags Flags { get; set; }
    public required UnmanagedEncodedString Name { get; set; }
    public required VkShaderStageFlags Stage { get; set; }
    public required ShaderModule Module { get; set; }
    public SpecializationInfo? SpecializationInfo { get; set; }

    public void Dispose()
    {
        Name.Dispose();
        Module.Dispose();
        SpecializationInfo?.Dispose();
    }
}
