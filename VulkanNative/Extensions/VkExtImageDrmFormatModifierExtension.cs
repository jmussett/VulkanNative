namespace VulkanNative;

public unsafe class VkExtImageDrmFormatModifierExtension
{
    public delegate* unmanaged[Cdecl]<VkDevice, VkImage, VkImageDrmFormatModifierPropertiesEXT*, VkResult> vkGetImageDrmFormatModifierPropertiesEXT;
}