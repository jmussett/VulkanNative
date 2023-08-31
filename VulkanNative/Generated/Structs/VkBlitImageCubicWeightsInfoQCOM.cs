using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBlitImageCubicWeightsInfoQCOM
{
    public VkStructureType sType;
    public void* pNext;
    public VkCubicFilterWeightsQCOM cubicWeights;
}