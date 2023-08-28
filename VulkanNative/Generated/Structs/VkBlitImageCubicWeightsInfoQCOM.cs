using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBlitImageCubicWeightsInfoQCOM
{
    public VkStructureType SType;
    public void* PNext;
    public VkCubicFilterWeightsQCOM CubicWeights;
}