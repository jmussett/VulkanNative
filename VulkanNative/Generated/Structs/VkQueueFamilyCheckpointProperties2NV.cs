using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkQueueFamilyCheckpointProperties2NV
{
    public VkStructureType sType;
    public void* pNext;
    public VkPipelineStageFlags2 checkpointExecutionStageMask;

    public VkQueueFamilyCheckpointProperties2NV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_QUEUE_FAMILY_CHECKPOINT_PROPERTIES_2_NV;
    }
}