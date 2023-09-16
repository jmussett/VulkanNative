using System;
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

    public IExtensionChain<InstanceDefinition>? Next { get; private set; } = null;

    public IExtensionChain<InstanceDefinition> Extend(IExtensionChain<InstanceDefinition> chain)
    {
        Next = chain;

        return chain;
    }
}

public interface IExtensionChain<T>
{
   nint ChainHandle { get; }
   IExtensionChain<InstanceDefinition> Extend(IExtensionChain<InstanceDefinition> chain);
}
