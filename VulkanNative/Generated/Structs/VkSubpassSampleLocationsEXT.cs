using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSubpassSampleLocationsEXT
{
    public uint subpassIndex;
    public VkSampleLocationsInfoEXT sampleLocationsInfo;
}