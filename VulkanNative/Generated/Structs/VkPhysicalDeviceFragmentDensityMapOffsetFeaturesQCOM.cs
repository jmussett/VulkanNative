using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceFragmentDensityMapOffsetFeaturesQCOM
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 fragmentDensityMapOffset;

    public VkPhysicalDeviceFragmentDensityMapOffsetFeaturesQCOM()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_OFFSET_FEATURES_QCOM;
    }
}