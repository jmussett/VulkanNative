using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCheckpointData2NV
{
    public VkStructureType SType;
    public void* PNext;
    public VkPipelineStageFlags2 Stage;
    public void* PCheckpointMarker;
}