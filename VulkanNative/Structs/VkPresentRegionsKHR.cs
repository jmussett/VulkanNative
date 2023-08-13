using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPresentRegionsKHR
{
    public VkStructureType SType;
    public void* PNext;
    public uint SwapchainCount;
    public VkPresentRegionKHR* PRegions;
}