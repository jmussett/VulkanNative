using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineSampleLocationsStateCreateInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 sampleLocationsEnable;
    public VkSampleLocationsInfoEXT sampleLocationsInfo;

    public VkPipelineSampleLocationsStateCreateInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_SAMPLE_LOCATIONS_STATE_CREATE_INFO_EXT;
    }
}