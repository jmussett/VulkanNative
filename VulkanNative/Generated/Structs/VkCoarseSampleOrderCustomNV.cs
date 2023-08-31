using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCoarseSampleOrderCustomNV
{
    public VkShadingRatePaletteEntryNV shadingRate;
    public uint sampleCount;
    public uint sampleLocationCount;
    public VkCoarseSampleLocationNV* pSampleLocations;
}