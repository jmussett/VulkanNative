using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkQueueFamilyCheckpointPropertiesNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkPipelineStageFlags checkpointExecutionStageMask;

    public VkQueueFamilyCheckpointPropertiesNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_QUEUE_FAMILY_CHECKPOINT_PROPERTIES_NV;
    }
}