using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkGeneratedCommandsMemoryRequirementsInfoNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkPipelineBindPoint pipelineBindPoint;
    public VkPipeline pipeline;
    public VkIndirectCommandsLayoutNV indirectCommandsLayout;
    public uint maxSequencesCount;
}