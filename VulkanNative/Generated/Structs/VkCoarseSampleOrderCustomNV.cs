using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCoarseSampleOrderCustomNV
{
    public VkShadingRatePaletteEntryNV ShadingRate;
    public uint SampleCount;
    public uint SampleLocationCount;
    public VkCoarseSampleLocationNV* PSampleLocations;
}