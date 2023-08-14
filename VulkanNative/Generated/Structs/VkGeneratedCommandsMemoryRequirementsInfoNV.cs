using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkGeneratedCommandsMemoryRequirementsInfoNV
{
    public VkStructureType SType;
    public void* PNext;
    public VkPipelineBindPoint PipelineBindPoint;
    public VkPipeline Pipeline;
    public VkIndirectCommandsLayoutNV IndirectCommandsLayout;
    public uint MaxSequencesCount;
}