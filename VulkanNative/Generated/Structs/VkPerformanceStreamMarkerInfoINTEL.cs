using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPerformanceStreamMarkerInfoINTEL
{
    public VkStructureType sType;
    public void* pNext;
    public uint marker;

    public VkPerformanceStreamMarkerInfoINTEL()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PERFORMANCE_STREAM_MARKER_INFO_INTEL;
    }
}