﻿using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrExternalFenceCapabilitiesExtension
{
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceExternalFenceInfo*, VkExternalFenceProperties*, void> _vkGetPhysicalDeviceExternalFenceProperties;

    public VkKhrExternalFenceCapabilitiesExtension(VkInstance instance, IVulkanLoader loader)
    {
        _vkGetPhysicalDeviceExternalFenceProperties = (delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceExternalFenceInfo*, VkExternalFenceProperties*, void>)loader.GetInstanceProcAddr(instance, "vkGetPhysicalDeviceExternalFenceProperties");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetPhysicalDeviceExternalFenceProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalFenceInfo* pExternalFenceInfo, VkExternalFenceProperties* pExternalFenceProperties)
    {
        _vkGetPhysicalDeviceExternalFenceProperties(physicalDevice, pExternalFenceInfo, pExternalFenceProperties);
    }
}