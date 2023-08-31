using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceFragmentDensityMapOffsetPropertiesQCOM
{
    public VkStructureType sType;
    public void* pNext;
    public VkExtent2D fragmentDensityOffsetGranularity;

    public VkPhysicalDeviceFragmentDensityMapOffsetPropertiesQCOM()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_OFFSET_PROPERTIES_QCOM;
    }
}