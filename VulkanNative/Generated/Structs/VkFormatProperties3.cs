using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkFormatProperties3
{
    public VkStructureType SType;
    public void* PNext;
    public VkFormatFeatureFlags2 LinearTilingFeatures;
    public VkFormatFeatureFlags2 OptimalTilingFeatures;
    public VkFormatFeatureFlags2 BufferFeatures;
}