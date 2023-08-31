using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceSamplerYcbcrConversionFeatures
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 samplerYcbcrConversion;

    public VkPhysicalDeviceSamplerYcbcrConversionFeatures()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLER_YCBCR_CONVERSION_FEATURES;
    }
}