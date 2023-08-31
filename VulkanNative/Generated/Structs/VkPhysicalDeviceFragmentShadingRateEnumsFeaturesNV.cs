using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceFragmentShadingRateEnumsFeaturesNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 fragmentShadingRateEnums;
    public VkBool32 supersampleFragmentShadingRates;
    public VkBool32 noInvocationFragmentShadingRates;

    public VkPhysicalDeviceFragmentShadingRateEnumsFeaturesNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_ENUMS_FEATURES_NV;
    }
}