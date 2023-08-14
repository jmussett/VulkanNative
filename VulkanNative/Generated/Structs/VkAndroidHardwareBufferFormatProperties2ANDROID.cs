using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAndroidHardwareBufferFormatProperties2ANDROID
{
    public VkStructureType SType;
    public void* PNext;
    public VkFormat Format;
    public ulong ExternalFormat;
    public VkFormatFeatureFlags2 FormatFeatures;
    public VkComponentMapping SamplerYcbcrConversionComponents;
    public VkSamplerYcbcrModelConversion SuggestedYcbcrModel;
    public VkSamplerYcbcrRange SuggestedYcbcrRange;
    public VkChromaLocation SuggestedXChromaOffset;
    public VkChromaLocation SuggestedYChromaOffset;
}