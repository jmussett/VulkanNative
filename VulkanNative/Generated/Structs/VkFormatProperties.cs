using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkFormatProperties
{
    public VkFormatFeatureFlags linearTilingFeatures;
    public VkFormatFeatureFlags optimalTilingFeatures;
    public VkFormatFeatureFlags bufferFeatures;
}