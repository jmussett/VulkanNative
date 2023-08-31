using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceSubpassShadingPropertiesHUAWEI
{
    public VkStructureType sType;
    public void* pNext;
    public uint maxSubpassShadingWorkgroupSizeAspectRatio;

    public VkPhysicalDeviceSubpassShadingPropertiesHUAWEI()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBPASS_SHADING_PROPERTIES_HUAWEI;
    }
}