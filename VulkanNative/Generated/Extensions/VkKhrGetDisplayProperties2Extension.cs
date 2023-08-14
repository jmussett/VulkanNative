﻿using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrGetDisplayProperties2Extension
{
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint*, VkDisplayProperties2KHR*, VkResult> _vkGetPhysicalDeviceDisplayProperties2KHR;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint*, VkDisplayPlaneProperties2KHR*, VkResult> _vkGetPhysicalDeviceDisplayPlaneProperties2KHR;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkDisplayKHR, uint*, VkDisplayModeProperties2KHR*, VkResult> _vkGetDisplayModeProperties2KHR;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkDisplayPlaneInfo2KHR*, VkDisplayPlaneCapabilities2KHR*, VkResult> _vkGetDisplayPlaneCapabilities2KHR;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetPhysicalDeviceDisplayProperties2KHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayProperties2KHR* pProperties)
    {
        return _vkGetPhysicalDeviceDisplayProperties2KHR(physicalDevice, pPropertyCount, pProperties);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetPhysicalDeviceDisplayPlaneProperties2KHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayPlaneProperties2KHR* pProperties)
    {
        return _vkGetPhysicalDeviceDisplayPlaneProperties2KHR(physicalDevice, pPropertyCount, pProperties);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetDisplayModeProperties2KHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint* pPropertyCount, VkDisplayModeProperties2KHR* pProperties)
    {
        return _vkGetDisplayModeProperties2KHR(physicalDevice, display, pPropertyCount, pProperties);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetDisplayPlaneCapabilities2KHR(VkPhysicalDevice physicalDevice, VkDisplayPlaneInfo2KHR* pDisplayPlaneInfo, VkDisplayPlaneCapabilities2KHR* pCapabilities)
    {
        return _vkGetDisplayPlaneCapabilities2KHR(physicalDevice, pDisplayPlaneInfo, pCapabilities);
    }
}