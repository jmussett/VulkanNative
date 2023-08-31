using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAndroidHardwareBufferFormatProperties2ANDROID
{
    public VkStructureType sType;
    public void* pNext;
    public VkFormat format;
    public ulong externalFormat;
    public VkFormatFeatureFlags2 formatFeatures;
    public VkComponentMapping samplerYcbcrConversionComponents;
    public VkSamplerYcbcrModelConversion suggestedYcbcrModel;
    public VkSamplerYcbcrRange suggestedYcbcrRange;
    public VkChromaLocation suggestedXChromaOffset;
    public VkChromaLocation suggestedYChromaOffset;

    public VkAndroidHardwareBufferFormatProperties2ANDROID()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_FORMAT_PROPERTIES_2_ANDROID;
    }
}