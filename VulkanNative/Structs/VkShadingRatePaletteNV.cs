using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkShadingRatePaletteNV
{
    public uint ShadingRatePaletteEntryCount;
    public VkShadingRatePaletteEntryNV* PShadingRatePaletteEntries;
}