using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineViewportShadingRateImageStateCreateInfoNV
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 ShadingRateImageEnable;
    public uint ViewportCount;
    public VkShadingRatePaletteNV* PShadingRatePalettes;
}