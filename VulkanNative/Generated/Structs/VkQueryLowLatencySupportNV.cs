using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkQueryLowLatencySupportNV
{
    public VkStructureType sType;
    public void* pNext;
    public void* pQueriedLowLatencyData;

    public VkQueryLowLatencySupportNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_QUERY_LOW_LATENCY_SUPPORT_NV;
    }
}