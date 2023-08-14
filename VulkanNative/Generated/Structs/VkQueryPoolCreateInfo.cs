using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkQueryPoolCreateInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkQueryPoolCreateFlags Flags;
    public VkQueryType QueryType;
    public uint QueryCount;
    public VkQueryPipelineStatisticFlags PipelineStatistics;
}