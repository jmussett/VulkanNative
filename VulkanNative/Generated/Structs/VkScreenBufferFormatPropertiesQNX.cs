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

    public VkScreenBufferFormatPropertiesQNX()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_SCREEN_BUFFER_FORMAT_PROPERTIES_QNX;
    }
}