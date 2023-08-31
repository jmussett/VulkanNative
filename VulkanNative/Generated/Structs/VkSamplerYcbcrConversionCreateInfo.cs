using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSamplerYcbcrConversionCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkFormat format;
    public VkSamplerYcbcrModelConversion ycbcrModel;
    public VkSamplerYcbcrRange ycbcrRange;
    public VkComponentMapping components;
    public VkChromaLocation xChromaOffset;
    public VkChromaLocation yChromaOffset;
    public VkFilter chromaFilter;
    public VkBool32 forceExplicitReconstruction;

    public VkSamplerYcbcrConversionCreateInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_CREATE_INFO;
    }
}