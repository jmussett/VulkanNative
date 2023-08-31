using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPresentRegionKHR
{
    public uint rectangleCount;
    public VkRectLayerKHR* pRectangles;
}