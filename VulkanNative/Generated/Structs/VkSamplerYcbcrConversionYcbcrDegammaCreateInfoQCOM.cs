using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSamplerYcbcrConversionYcbcrDegammaCreateInfoQCOM
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 enableYDegamma;
    public VkBool32 enableCbCrDegamma;

    public VkSamplerYcbcrConversionYcbcrDegammaCreateInfoQCOM()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_YCBCR_DEGAMMA_CREATE_INFO_QCOM;
    }
}