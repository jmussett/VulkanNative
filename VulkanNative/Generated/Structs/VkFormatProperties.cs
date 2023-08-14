using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkFormatProperties
{
    public VkFormatFeatureFlags LinearTilingFeatures;
    public VkFormatFeatureFlags OptimalTilingFeatures;
    public VkFormatFeatureFlags BufferFeatures;
}