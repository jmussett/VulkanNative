using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDrmFormatModifierPropertiesEXT
{
    public ulong drmFormatModifier;
    public uint drmFormatModifierPlaneCount;
    public VkFormatFeatureFlags drmFormatModifierTilingFeatures;
}