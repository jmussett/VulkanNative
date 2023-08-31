using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBufferCollectionPropertiesFUCHSIA
{
    public VkStructureType sType;
    public void* pNext;
    public uint memoryTypeBits;
    public uint bufferCount;
    public uint createInfoIndex;
    public ulong sysmemPixelFormat;
    public VkFormatFeatureFlags formatFeatures;
    public VkSysmemColorSpaceFUCHSIA sysmemColorSpaceIndex;
    public VkComponentMapping samplerYcbcrConversionComponents;
    public VkSamplerYcbcrModelConversion suggestedYcbcrModel;
    public VkSamplerYcbcrRange suggestedYcbcrRange;
    public VkChromaLocation suggestedXChromaOffset;
    public VkChromaLocation suggestedYChromaOffset;
}