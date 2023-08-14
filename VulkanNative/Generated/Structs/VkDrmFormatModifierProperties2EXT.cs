using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDrmFormatModifierProperties2EXT
{
    public ulong DrmFormatModifier;
    public uint DrmFormatModifierPlaneCount;
    public VkFormatFeatureFlags2 DrmFormatModifierTilingFeatures;
}