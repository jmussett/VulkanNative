using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkQueryPoolCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkQueryPoolCreateFlags flags;
    public VkQueryType queryType;
    public uint queryCount;
    public VkQueryPipelineStatisticFlags pipelineStatistics;

    public VkQueryPoolCreateInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_QUERY_POOL_CREATE_INFO;
    }
}