namespace VulkanNative;

public unsafe class VkAndroidExternalMemoryAndroidHardwareBufferExtension
{
    public delegate* unmanaged[Cdecl]<VkDevice, AHardwareBuffer*, VkAndroidHardwareBufferPropertiesANDROID*, VkResult> vkGetAndroidHardwareBufferPropertiesANDROID;
    public delegate* unmanaged[Cdecl]<VkDevice, VkMemoryGetAndroidHardwareBufferInfoANDROID*, AHardwareBuffer**, VkResult> vkGetMemoryAndroidHardwareBufferANDROID;
}