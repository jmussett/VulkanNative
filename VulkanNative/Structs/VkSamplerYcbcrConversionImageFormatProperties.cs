using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSamplerYcbcrConversionImageFormatProperties
{
    public VkStructureType sType;
    public void* pNext;
    public uint combinedImageSamplerDescriptorCount;
}