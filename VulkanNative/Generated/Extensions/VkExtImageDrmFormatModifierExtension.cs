﻿using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtImageDrmFormatModifierExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkImage, VkImageDrmFormatModifierPropertiesEXT*, VkResult> _vkGetImageDrmFormatModifierPropertiesEXT;

    public VkExtImageDrmFormatModifierExtension(VkDevice device, IFunctionLoader loader)
    {
        _vkGetImageDrmFormatModifierPropertiesEXT = (delegate* unmanaged[Cdecl]<VkDevice, VkImage, VkImageDrmFormatModifierPropertiesEXT*, VkResult>)loader.GetDeviceProcAddr(device, "vkGetImageDrmFormatModifierPropertiesEXT");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkGetImageDrmFormatModifierPropertiesEXT(VkDevice device, VkImage image, VkImageDrmFormatModifierPropertiesEXT* pProperties)
    {
        return _vkGetImageDrmFormatModifierPropertiesEXT(device, image, pProperties);
    }
}