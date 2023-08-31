using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCheckpointData2NV
{
    public VkStructureType sType;
    public void* pNext;
    public VkPipelineStageFlags2 stage;
    public void* pCheckpointMarker;

    public VkCheckpointData2NV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_CHECKPOINT_DATA_2_NV;
    }
}