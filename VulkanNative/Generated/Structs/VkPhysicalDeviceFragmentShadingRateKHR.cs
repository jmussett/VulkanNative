using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceFragmentShadingRateKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkSampleCountFlags sampleCounts;
    public VkExtent2D fragmentSize;

    public VkPhysicalDeviceFragmentShadingRateKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_KHR;
    }
}