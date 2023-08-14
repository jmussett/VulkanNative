using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSampleLocationsInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkSampleCountFlags SampleLocationsPerPixel;
    public VkExtent2D SampleLocationGridSize;
    public uint SampleLocationsCount;
    public VkSampleLocationEXT* PSampleLocations;
}