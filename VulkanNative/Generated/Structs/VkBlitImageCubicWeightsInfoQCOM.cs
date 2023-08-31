using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBlitImageCubicWeightsInfoQCOM
{
    public VkStructureType sType;
    public void* pNext;
    public VkCubicFilterWeightsQCOM cubicWeights;

    public VkBlitImageCubicWeightsInfoQCOM()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_BLIT_IMAGE_CUBIC_WEIGHTS_INFO_QCOM;
    }
}