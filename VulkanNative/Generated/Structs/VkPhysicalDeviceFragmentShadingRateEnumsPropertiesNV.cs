using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceFragmentShadingRateEnumsPropertiesNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkSampleCountFlags maxFragmentShadingRateInvocationCount;

    public VkPhysicalDeviceFragmentShadingRateEnumsPropertiesNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_ENUMS_PROPERTIES_NV;
    }
}