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
}