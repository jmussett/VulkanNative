using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPerformanceQueryReservationInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public uint MaxPerformanceQueriesPerPool;
}