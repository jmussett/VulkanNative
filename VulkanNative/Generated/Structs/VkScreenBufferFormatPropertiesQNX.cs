using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkScreenBufferFormatPropertiesQNX
{
    public VkStructureType sType;
    public void* pNext;
    public VkFormat format;
    public ulong externalFormat;
    public ulong screenUsage;
    public VkFormatFeatureFlags formatFeatures;
    public VkComponentMapping samplerYcbcrConversionComponents;
    public VkSamplerYcbcrModelConversion suggestedYcbcrModel;
    public VkSamplerYcbcrRange suggestedYcbcrRange;
    public VkChromaLocation suggestedXChromaOffset;
    public VkChromaLocation suggestedYChromaOffset;
}