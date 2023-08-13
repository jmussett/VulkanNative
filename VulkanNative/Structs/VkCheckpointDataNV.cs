using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCheckpointDataNV
{
    public VkStructureType SType;
    public void* PNext;
    public VkPipelineStageFlags Stage;
    public void* PCheckpointMarker;
}