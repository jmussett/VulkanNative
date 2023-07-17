using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkLayerProperties
{
    public char layerName;
    public uint specVersion;
    public uint implementationVersion;
    public char description;
}