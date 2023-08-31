using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPerformanceQueryReservationInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public uint maxPerformanceQueriesPerPool;
}