using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtImageDrmFormatModifierExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkImage, VkImageDrmFormatModifierPropertiesEXT*, VkResult> _vkGetImageDrmFormatModifierPropertiesEXT;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetImageDrmFormatModifierPropertiesEXT(VkDevice device, VkImage image, VkImageDrmFormatModifierPropertiesEXT* pProperties)
    {
        return _vkGetImageDrmFormatModifierPropertiesEXT(device, image, pProperties);
    }
}