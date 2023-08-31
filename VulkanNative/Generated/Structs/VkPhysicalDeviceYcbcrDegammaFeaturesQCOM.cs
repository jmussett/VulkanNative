using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceYcbcrDegammaFeaturesQCOM
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 ycbcrDegamma;

    public VkPhysicalDeviceYcbcrDegammaFeaturesQCOM()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_YCBCR_DEGAMMA_FEATURES_QCOM;
    }
}