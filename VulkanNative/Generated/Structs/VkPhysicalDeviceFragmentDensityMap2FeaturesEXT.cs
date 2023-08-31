using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceFragmentDensityMap2FeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 fragmentDensityMapDeferred;

    public VkPhysicalDeviceFragmentDensityMap2FeaturesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_2_FEATURES_EXT;
    }
}