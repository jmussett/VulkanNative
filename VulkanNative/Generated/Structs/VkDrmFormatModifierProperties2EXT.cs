using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDrmFormatModifierProperties2EXT
{
    public ulong drmFormatModifier;
    public uint drmFormatModifierPlaneCount;
    public VkFormatFeatureFlags2 drmFormatModifierTilingFeatures;
}