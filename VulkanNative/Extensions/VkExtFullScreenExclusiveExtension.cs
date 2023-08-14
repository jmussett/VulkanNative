﻿using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtFullScreenExclusiveExtension
{
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceSurfaceInfo2KHR*, uint*, VkPresentModeKHR*, VkResult> _vkGetPhysicalDeviceSurfacePresentModes2EXT;
    private delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, VkResult> _vkAcquireFullScreenExclusiveModeEXT;
    private delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, VkResult> _vkReleaseFullScreenExclusiveModeEXT;
    private delegate* unmanaged[Cdecl]<VkDevice, VkPhysicalDeviceSurfaceInfo2KHR*, VkDeviceGroupPresentModeFlagsKHR*, VkResult> _vkGetDeviceGroupSurfacePresentModes2EXT;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, uint* pPresentModeCount, VkPresentModeKHR* pPresentModes)
    {
        return _vkGetPhysicalDeviceSurfacePresentModes2EXT(physicalDevice, pSurfaceInfo, pPresentModeCount, pPresentModes);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkAcquireFullScreenExclusiveModeEXT(VkDevice device, VkSwapchainKHR swapchain)
    {
        return _vkAcquireFullScreenExclusiveModeEXT(device, swapchain);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkReleaseFullScreenExclusiveModeEXT(VkDevice device, VkSwapchainKHR swapchain)
    {
        return _vkReleaseFullScreenExclusiveModeEXT(device, swapchain);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetDeviceGroupSurfacePresentModes2EXT(VkDevice device, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, VkDeviceGroupPresentModeFlagsKHR* pModes)
    {
        return _vkGetDeviceGroupSurfacePresentModes2EXT(device, pSurfaceInfo, pModes);
    }
}