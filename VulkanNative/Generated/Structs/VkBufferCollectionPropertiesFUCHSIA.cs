using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBufferCollectionPropertiesFUCHSIA
{
    public VkStructureType SType;
    public void* PNext;
    public uint MemoryTypeBits;
    public uint BufferCount;
    public uint CreateInfoIndex;
    public ulong SysmemPixelFormat;
    public VkFormatFeatureFlags FormatFeatures;
    public VkSysmemColorSpaceFUCHSIA SysmemColorSpaceIndex;
    public VkComponentMapping SamplerYcbcrConversionComponents;
    public VkSamplerYcbcrModelConversion SuggestedYcbcrModel;
    public VkSamplerYcbcrRange SuggestedYcbcrRange;
    public VkChromaLocation SuggestedXChromaOffset;
    public VkChromaLocation SuggestedYChromaOffset;
}