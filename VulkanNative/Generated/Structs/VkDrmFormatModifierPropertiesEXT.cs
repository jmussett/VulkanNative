using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDrmFormatModifierPropertiesEXT
{
    public ulong DrmFormatModifier;
    public uint DrmFormatModifierPlaneCount;
    public VkFormatFeatureFlags DrmFormatModifierTilingFeatures;
}