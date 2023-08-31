using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceImageProcessingFeaturesQCOM
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 textureSampleWeighted;
    public VkBool32 textureBoxFilter;
    public VkBool32 textureBlockMatch;

    public VkPhysicalDeviceImageProcessingFeaturesQCOM()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_PROCESSING_FEATURES_QCOM;
    }
}