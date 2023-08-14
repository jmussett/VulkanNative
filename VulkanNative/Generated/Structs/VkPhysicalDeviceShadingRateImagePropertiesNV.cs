using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceShadingRateImagePropertiesNV
{
    public VkStructureType SType;
    public void* PNext;
    public VkExtent2D ShadingRateTexelSize;
    public uint ShadingRatePaletteSize;
    public uint ShadingRateMaxCoarseSamples;
}