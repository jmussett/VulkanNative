using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineCreationFeedbackCreateInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkPipelineCreationFeedback* PPipelineCreationFeedback;
    public uint PipelineStageCreationFeedbackCount;
    public VkPipelineCreationFeedback* PPipelineStageCreationFeedbacks;
}