using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceFragmentShadingRateKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkSampleCountFlags sampleCounts;
    public VkExtent2D fragmentSize;
}