﻿using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtSampleLocationsExtension
{
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkSampleLocationsInfoEXT*, void> _vkCmdSetSampleLocationsEXT;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkSampleCountFlags, VkMultisamplePropertiesEXT*, void> _vkGetPhysicalDeviceMultisamplePropertiesEXT;

    public VkExtSampleLocationsExtension(VkDevice device, IFunctionLoader loader)
    {
        _vkCmdSetSampleLocationsEXT = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkSampleLocationsInfoEXT*, void>)loader.GetDeviceProcAddr(device, "vkCmdSetSampleLocationsEXT");
        _vkGetPhysicalDeviceMultisamplePropertiesEXT = (delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkSampleCountFlags, VkMultisamplePropertiesEXT*, void>)loader.GetDeviceProcAddr(device, "vkGetPhysicalDeviceMultisamplePropertiesEXT");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkCmdSetSampleLocationsEXT(VkCommandBuffer commandBuffer, VkSampleLocationsInfoEXT* pSampleLocationsInfo)
    {
        _vkCmdSetSampleLocationsEXT(commandBuffer, pSampleLocationsInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkGetPhysicalDeviceMultisamplePropertiesEXT(VkPhysicalDevice physicalDevice, VkSampleCountFlags samples, VkMultisamplePropertiesEXT* pMultisampleProperties)
    {
        _vkGetPhysicalDeviceMultisamplePropertiesEXT(physicalDevice, samples, pMultisampleProperties);
    }
}