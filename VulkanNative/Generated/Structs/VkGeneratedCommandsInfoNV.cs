using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkGeneratedCommandsInfoNV
{
    public VkStructureType SType;
    public void* PNext;
    public VkPipelineBindPoint PipelineBindPoint;
    public VkPipeline Pipeline;
    public VkIndirectCommandsLayoutNV IndirectCommandsLayout;
    public uint StreamCount;
    public VkIndirectCommandsStreamNV* PStreams;
    public uint SequencesCount;
    public VkBuffer PreprocessBuffer;
    public VkDeviceSize PreprocessOffset;
    public VkDeviceSize PreprocessSize;
    public VkBuffer SequencesCountBuffer;
    public VkDeviceSize SequencesCountOffset;
    public VkBuffer SequencesIndexBuffer;
    public VkDeviceSize SequencesIndexOffset;
}