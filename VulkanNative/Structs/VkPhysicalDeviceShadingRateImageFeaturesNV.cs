using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceShadingRateImageFeaturesNV
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 ShadingRateImage;
    public VkBool32 ShadingRateCoarseSampleOrder;
}