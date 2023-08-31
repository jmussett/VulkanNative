using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceImageProcessing2FeaturesQCOM
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 textureBlockMatch2;

    public VkPhysicalDeviceImageProcessing2FeaturesQCOM()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_PROCESSING_2_FEATURES_QCOM;
    }
}