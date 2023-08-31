using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCheckpointDataNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkPipelineStageFlags stage;
    public void* pCheckpointMarker;

    public VkCheckpointDataNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_CHECKPOINT_DATA_NV;
    }
}