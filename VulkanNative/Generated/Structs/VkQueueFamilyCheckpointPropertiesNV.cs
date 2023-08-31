using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkQueueFamilyCheckpointPropertiesNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkPipelineStageFlags checkpointExecutionStageMask;
}