namespace VulkanNative.Examples.Common;

public struct ExtensionProperties
{
    public string ExtensionName;

    // TODO: Version
    public uint SpecVersion;

    public override readonly string ToString()
    {
        return ExtensionName;
    }
}
