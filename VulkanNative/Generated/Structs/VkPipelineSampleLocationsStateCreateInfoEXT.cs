using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineSampleLocationsStateCreateInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 SampleLocationsEnable;
    public VkSampleLocationsInfoEXT SampleLocationsInfo;
}