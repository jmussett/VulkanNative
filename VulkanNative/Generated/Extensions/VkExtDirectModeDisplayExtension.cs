﻿using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtDirectModeDisplayExtension
{
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkDisplayKHR, VkResult> _vkReleaseDisplayEXT;

    public VkExtDirectModeDisplayExtension(VkInstance instance, IFunctionLoader loader)
    {
        _vkReleaseDisplayEXT = (delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkDisplayKHR, VkResult>)loader.GetInstanceProcAddr(instance, "vkReleaseDisplayEXT");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkReleaseDisplayEXT(VkPhysicalDevice physicalDevice, VkDisplayKHR display)
    {
        return _vkReleaseDisplayEXT(physicalDevice, display);
    }
}