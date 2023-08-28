namespace VulkanNative.Examples.Common;

public struct LayerProperties
{
    public string LayerName;

    // TODO: Version
    public uint SpecVersion;

    // TODO: Version
    public uint ImplementationVersion;

    public string Description;

    public override readonly string ToString()
    {
        return LayerName;
    }
}
