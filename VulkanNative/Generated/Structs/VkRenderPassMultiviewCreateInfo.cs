using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderPassMultiviewCreateInfo
{
    public VkStructureType SType;
    public void* PNext;
    public uint SubpassCount;
    public uint* PViewMasks;
    public uint DependencyCount;
    public int* PViewOffsets;
    public uint CorrelationMaskCount;
    public uint* PCorrelationMasks;
}