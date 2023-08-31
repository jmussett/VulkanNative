using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceShadingRateImagePropertiesNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkExtent2D shadingRateTexelSize;
    public uint shadingRatePaletteSize;
    public uint shadingRateMaxCoarseSamples;

    public VkPhysicalDeviceShadingRateImagePropertiesNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADING_RATE_IMAGE_PROPERTIES_NV;
    }
}