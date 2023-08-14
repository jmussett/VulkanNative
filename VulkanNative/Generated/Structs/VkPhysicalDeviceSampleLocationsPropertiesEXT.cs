using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceSampleLocationsPropertiesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkSampleCountFlags SampleLocationSampleCounts;
    public VkExtent2D MaxSampleLocationGridSize;
    public fixed float SampleLocationCoordinateRange[2];
    public uint SampleLocationSubPixelBits;
    public VkBool32 VariableSampleLocations;
}