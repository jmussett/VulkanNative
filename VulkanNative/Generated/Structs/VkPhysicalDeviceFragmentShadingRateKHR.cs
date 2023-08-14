using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceFragmentShadingRateKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkSampleCountFlags SampleCounts;
    public VkExtent2D FragmentSize;
}