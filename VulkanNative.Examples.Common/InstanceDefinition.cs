using VulkanNative.Examples.Common.Utility;

namespace VulkanNative.Examples.Common;

public class InstanceDefinition
{
    public string? AppName { get; set; }
    public string? EngineName { get; set; }
    public VulkanVersion AppVersion { get; set; }
    public VulkanVersion EngineVersion { get; set; }
    public VulkanVersion ApiVersion { get; set; }
    public string[] EnabledLayers { get; set; } = Array.Empty<string>();
    public string[] EnabledExtensions { get; set; } = Array.Empty<string>();
}
