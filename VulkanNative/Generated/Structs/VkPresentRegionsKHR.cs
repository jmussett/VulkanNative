using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPresentRegionsKHR
{
    public VkStructureType sType;
    public void* pNext;
    public uint swapchainCount;
    public VkPresentRegionKHR* pRegions;

    public VkPresentRegionsKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PRESENT_REGIONS_KHR;
    }
}