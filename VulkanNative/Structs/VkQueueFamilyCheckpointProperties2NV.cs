using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkQueueFamilyCheckpointProperties2NV
{
    public VkStructureType SType;
    public void* PNext;
    public VkPipelineStageFlags2 CheckpointExecutionStageMask;
}