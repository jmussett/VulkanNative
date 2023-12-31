﻿using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrDeviceGroupExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, uint, uint, uint, VkPeerMemoryFeatureFlags*, void> _vkGetDeviceGroupPeerMemoryFeatures;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, void> _vkCmdSetDeviceMask;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, uint, uint, uint, uint, void> _vkCmdDispatchBase;
    private delegate* unmanaged[Cdecl]<VkDevice, VkDeviceGroupPresentCapabilitiesKHR*, VkResult> _vkGetDeviceGroupPresentCapabilitiesKHR;
    private delegate* unmanaged[Cdecl]<VkDevice, VkSurfaceKHR, VkDeviceGroupPresentModeFlagsKHR*, VkResult> _vkGetDeviceGroupSurfacePresentModesKHR;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkSurfaceKHR, uint*, VkRect2D*, VkResult> _vkGetPhysicalDevicePresentRectanglesKHR;
    private delegate* unmanaged[Cdecl]<VkDevice, VkAcquireNextImageInfoKHR*, uint*, VkResult> _vkAcquireNextImage2KHR;

    public VkKhrDeviceGroupExtension(VkDevice device, IFunctionLoader loader)
    {
        _vkGetDeviceGroupPeerMemoryFeatures = (delegate* unmanaged[Cdecl]<VkDevice, uint, uint, uint, VkPeerMemoryFeatureFlags*, void>)loader.GetDeviceProcAddr(device, "vkGetDeviceGroupPeerMemoryFeatures");
        _vkCmdSetDeviceMask = (delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, void>)loader.GetDeviceProcAddr(device, "vkCmdSetDeviceMask");
        _vkCmdDispatchBase = (delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, uint, uint, uint, uint, void>)loader.GetDeviceProcAddr(device, "vkCmdDispatchBase");
        _vkGetDeviceGroupPresentCapabilitiesKHR = (delegate* unmanaged[Cdecl]<VkDevice, VkDeviceGroupPresentCapabilitiesKHR*, VkResult>)loader.GetDeviceProcAddr(device, "vkGetDeviceGroupPresentCapabilitiesKHR");
        _vkGetDeviceGroupSurfacePresentModesKHR = (delegate* unmanaged[Cdecl]<VkDevice, VkSurfaceKHR, VkDeviceGroupPresentModeFlagsKHR*, VkResult>)loader.GetDeviceProcAddr(device, "vkGetDeviceGroupSurfacePresentModesKHR");
        _vkGetPhysicalDevicePresentRectanglesKHR = (delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkSurfaceKHR, uint*, VkRect2D*, VkResult>)loader.GetDeviceProcAddr(device, "vkGetPhysicalDevicePresentRectanglesKHR");
        _vkAcquireNextImage2KHR = (delegate* unmanaged[Cdecl]<VkDevice, VkAcquireNextImageInfoKHR*, uint*, VkResult>)loader.GetDeviceProcAddr(device, "vkAcquireNextImage2KHR");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkGetDeviceGroupPeerMemoryFeatures(VkDevice device, uint heapIndex, uint localDeviceIndex, uint remoteDeviceIndex, VkPeerMemoryFeatureFlags* pPeerMemoryFeatures)
    {
        _vkGetDeviceGroupPeerMemoryFeatures(device, heapIndex, localDeviceIndex, remoteDeviceIndex, pPeerMemoryFeatures);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkCmdSetDeviceMask(VkCommandBuffer commandBuffer, uint deviceMask)
    {
        _vkCmdSetDeviceMask(commandBuffer, deviceMask);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkCmdDispatchBase(VkCommandBuffer commandBuffer, uint baseGroupX, uint baseGroupY, uint baseGroupZ, uint groupCountX, uint groupCountY, uint groupCountZ)
    {
        _vkCmdDispatchBase(commandBuffer, baseGroupX, baseGroupY, baseGroupZ, groupCountX, groupCountY, groupCountZ);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkGetDeviceGroupPresentCapabilitiesKHR(VkDevice device, VkDeviceGroupPresentCapabilitiesKHR* pDeviceGroupPresentCapabilities)
    {
        return _vkGetDeviceGroupPresentCapabilitiesKHR(device, pDeviceGroupPresentCapabilities);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkGetDeviceGroupSurfacePresentModesKHR(VkDevice device, VkSurfaceKHR surface, VkDeviceGroupPresentModeFlagsKHR* pModes)
    {
        return _vkGetDeviceGroupSurfacePresentModesKHR(device, surface, pModes);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkGetPhysicalDevicePresentRectanglesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pRectCount, VkRect2D* pRects)
    {
        return _vkGetPhysicalDevicePresentRectanglesKHR(physicalDevice, surface, pRectCount, pRects);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkAcquireNextImage2KHR(VkDevice device, VkAcquireNextImageInfoKHR* pAcquireInfo, uint* pImageIndex)
    {
        return _vkAcquireNextImage2KHR(device, pAcquireInfo, pImageIndex);
    }
}