using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceFragmentDensityMapFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 fragmentDensityMap;
    public VkBool32 fragmentDensityMapDynamic;
    public VkBool32 fragmentDensityMapNonSubsampledImages;

    public VkPhysicalDeviceFragmentDensityMapFeaturesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_FEATURES_EXT;
    }
}