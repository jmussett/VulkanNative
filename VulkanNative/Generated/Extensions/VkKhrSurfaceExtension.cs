﻿using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrSurfaceExtension
{
    private delegate* unmanaged[Cdecl]<VkInstance, VkSurfaceKHR, VkAllocationCallbacks*, void> _vkDestroySurfaceKHR;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint, VkSurfaceKHR, VkBool32*, VkResult> _vkGetPhysicalDeviceSurfaceSupportKHR;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkSurfaceKHR, VkSurfaceCapabilitiesKHR*, VkResult> _vkGetPhysicalDeviceSurfaceCapabilitiesKHR;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkSurfaceKHR, uint*, VkSurfaceFormatKHR*, VkResult> _vkGetPhysicalDeviceSurfaceFormatsKHR;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkSurfaceKHR, uint*, VkPresentModeKHR*, VkResult> _vkGetPhysicalDeviceSurfacePresentModesKHR;

    public VkKhrSurfaceExtension(VkInstance instance, IFunctionLoader loader)
    {
        _vkDestroySurfaceKHR = (delegate* unmanaged[Cdecl]<VkInstance, VkSurfaceKHR, VkAllocationCallbacks*, void>)loader.GetInstanceProcAddr(instance, "vkDestroySurfaceKHR");
        _vkGetPhysicalDeviceSurfaceSupportKHR = (delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint, VkSurfaceKHR, VkBool32*, VkResult>)loader.GetInstanceProcAddr(instance, "vkGetPhysicalDeviceSurfaceSupportKHR");
        _vkGetPhysicalDeviceSurfaceCapabilitiesKHR = (delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkSurfaceKHR, VkSurfaceCapabilitiesKHR*, VkResult>)loader.GetInstanceProcAddr(instance, "vkGetPhysicalDeviceSurfaceCapabilitiesKHR");
        _vkGetPhysicalDeviceSurfaceFormatsKHR = (delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkSurfaceKHR, uint*, VkSurfaceFormatKHR*, VkResult>)loader.GetInstanceProcAddr(instance, "vkGetPhysicalDeviceSurfaceFormatsKHR");
        _vkGetPhysicalDeviceSurfacePresentModesKHR = (delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkSurfaceKHR, uint*, VkPresentModeKHR*, VkResult>)loader.GetInstanceProcAddr(instance, "vkGetPhysicalDeviceSurfacePresentModesKHR");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkDestroySurfaceKHR(VkInstance instance, VkSurfaceKHR surface, VkAllocationCallbacks* pAllocator)
    {
        _vkDestroySurfaceKHR(instance, surface, pAllocator);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkGetPhysicalDeviceSurfaceSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, VkSurfaceKHR surface, VkBool32* pSupported)
    {
        return _vkGetPhysicalDeviceSurfaceSupportKHR(physicalDevice, queueFamilyIndex, surface, pSupported);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkGetPhysicalDeviceSurfaceCapabilitiesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, VkSurfaceCapabilitiesKHR* pSurfaceCapabilities)
    {
        return _vkGetPhysicalDeviceSurfaceCapabilitiesKHR(physicalDevice, surface, pSurfaceCapabilities);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkGetPhysicalDeviceSurfaceFormatsKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pSurfaceFormatCount, VkSurfaceFormatKHR* pSurfaceFormats)
    {
        return _vkGetPhysicalDeviceSurfaceFormatsKHR(physicalDevice, surface, pSurfaceFormatCount, pSurfaceFormats);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkGetPhysicalDeviceSurfacePresentModesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pPresentModeCount, VkPresentModeKHR* pPresentModes)
    {
        return _vkGetPhysicalDeviceSurfacePresentModesKHR(physicalDevice, surface, pPresentModeCount, pPresentModes);
    }
}