using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkGeneratedCommandsInfoNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkPipelineBindPoint pipelineBindPoint;
    public VkPipeline pipeline;
    public VkIndirectCommandsLayoutNV indirectCommandsLayout;
    public uint streamCount;
    public VkIndirectCommandsStreamNV* pStreams;
    public uint sequencesCount;
    public VkBuffer preprocessBuffer;
    public VkDeviceSize preprocessOffset;
    public VkDeviceSize preprocessSize;
    public VkBuffer sequencesCountBuffer;
    public VkDeviceSize sequencesCountOffset;
    public VkBuffer sequencesIndexBuffer;
    public VkDeviceSize sequencesIndexOffset;
}