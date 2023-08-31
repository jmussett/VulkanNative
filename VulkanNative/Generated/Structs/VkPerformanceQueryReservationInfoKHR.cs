using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPerformanceQueryReservationInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public uint maxPerformanceQueriesPerPool;

    public VkPerformanceQueryReservationInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PERFORMANCE_QUERY_RESERVATION_INFO_KHR;
    }
}