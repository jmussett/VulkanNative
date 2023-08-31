using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceSubpassShadingFeaturesHUAWEI
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 subpassShading;

    public VkPhysicalDeviceSubpassShadingFeaturesHUAWEI()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBPASS_SHADING_FEATURES_HUAWEI;
    }
}