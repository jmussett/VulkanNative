using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPerformanceQuerySubmitInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public uint counterPassIndex;

    public VkPerformanceQuerySubmitInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PERFORMANCE_QUERY_SUBMIT_INFO_KHR;
    }
}