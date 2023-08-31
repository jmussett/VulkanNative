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

    public VkGeneratedCommandsMemoryRequirementsInfoNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_GENERATED_COMMANDS_MEMORY_REQUIREMENTS_INFO_NV;
    }
}