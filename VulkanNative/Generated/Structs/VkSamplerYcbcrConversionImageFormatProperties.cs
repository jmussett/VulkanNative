using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSamplerYcbcrConversionImageFormatProperties
{
    public VkStructureType sType;
    public void* pNext;
    public uint combinedImageSamplerDescriptorCount;

    public VkSamplerYcbcrConversionImageFormatProperties()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_IMAGE_FORMAT_PROPERTIES;
    }
}