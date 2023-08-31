using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPerformanceMarkerInfoINTEL
{
    public VkStructureType sType;
    public void* pNext;
    public ulong marker;

    public VkPerformanceMarkerInfoINTEL()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PERFORMANCE_MARKER_INFO_INTEL;
    }
}