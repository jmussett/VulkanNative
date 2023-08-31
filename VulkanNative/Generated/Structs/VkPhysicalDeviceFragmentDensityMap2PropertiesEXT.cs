using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceFragmentDensityMap2PropertiesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 subsampledLoads;
    public VkBool32 subsampledCoarseReconstructionEarlyAccess;
    public uint maxSubsampledArrayLayers;
    public uint maxDescriptorSetSubsampledSamplers;

    public VkPhysicalDeviceFragmentDensityMap2PropertiesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_2_PROPERTIES_EXT;
    }
}