using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceSampleLocationsPropertiesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkSampleCountFlags sampleLocationSampleCounts;
    public VkExtent2D maxSampleLocationGridSize;
    public fixed float sampleLocationCoordinateRange[2];
    public uint sampleLocationSubPixelBits;
    public VkBool32 variableSampleLocations;

    public VkPhysicalDeviceSampleLocationsPropertiesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLE_LOCATIONS_PROPERTIES_EXT;
    }
}