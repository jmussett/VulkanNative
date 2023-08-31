using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSampleLocationsInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkSampleCountFlags sampleLocationsPerPixel;
    public VkExtent2D sampleLocationGridSize;
    public uint sampleLocationsCount;
    public VkSampleLocationEXT* pSampleLocations;
}