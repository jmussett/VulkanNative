﻿using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtToolingInfoExtension
{
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint*, VkPhysicalDeviceToolProperties*, VkResult> _vkGetPhysicalDeviceToolProperties;

    public VkExtToolingInfoExtension(VkDevice device, IFunctionLoader loader)
    {
        _vkGetPhysicalDeviceToolProperties = (delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint*, VkPhysicalDeviceToolProperties*, VkResult>)loader.GetDeviceProcAddr(device, "vkGetPhysicalDeviceToolProperties");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkGetPhysicalDeviceToolProperties(VkPhysicalDevice physicalDevice, uint* pToolCount, VkPhysicalDeviceToolProperties* pToolProperties)
    {
        return _vkGetPhysicalDeviceToolProperties(physicalDevice, pToolCount, pToolProperties);
    }
}