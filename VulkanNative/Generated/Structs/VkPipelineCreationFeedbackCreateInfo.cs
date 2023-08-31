using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineCreationFeedbackCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkPipelineCreationFeedback* pPipelineCreationFeedback;
    public uint pipelineStageCreationFeedbackCount;
    public VkPipelineCreationFeedback* pPipelineStageCreationFeedbacks;
}