using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkQueryPoolPerformanceCreateInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public uint queueFamilyIndex;
    public uint counterIndexCount;
    public uint* pCounterIndices;

    public VkQueryPoolPerformanceCreateInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_QUERY_POOL_PERFORMANCE_CREATE_INFO_KHR;
    }
}