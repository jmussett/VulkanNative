using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSamplerCubicWeightsCreateInfoQCOM
{
    public VkStructureType SType;
    public void* PNext;
    public VkCubicFilterWeightsQCOM CubicWeights;
}