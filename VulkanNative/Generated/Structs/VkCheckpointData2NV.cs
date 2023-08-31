using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCheckpointData2NV
{
    public VkStructureType sType;
    public void* pNext;
    public VkPipelineStageFlags2 stage;
    public void* pCheckpointMarker;
}