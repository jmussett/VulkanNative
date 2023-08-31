using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceCornerSampledImageFeaturesNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 cornerSampledImage;

    public VkPhysicalDeviceCornerSampledImageFeaturesNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CORNER_SAMPLED_IMAGE_FEATURES_NV;
    }
}