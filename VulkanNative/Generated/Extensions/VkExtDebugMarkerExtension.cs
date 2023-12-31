﻿using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtDebugMarkerExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkDebugMarkerObjectTagInfoEXT*, VkResult> _vkDebugMarkerSetObjectTagEXT;
    private delegate* unmanaged[Cdecl]<VkDevice, VkDebugMarkerObjectNameInfoEXT*, VkResult> _vkDebugMarkerSetObjectNameEXT;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDebugMarkerMarkerInfoEXT*, void> _vkCmdDebugMarkerBeginEXT;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, void> _vkCmdDebugMarkerEndEXT;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDebugMarkerMarkerInfoEXT*, void> _vkCmdDebugMarkerInsertEXT;

    public VkExtDebugMarkerExtension(VkDevice device, IFunctionLoader loader)
    {
        _vkDebugMarkerSetObjectTagEXT = (delegate* unmanaged[Cdecl]<VkDevice, VkDebugMarkerObjectTagInfoEXT*, VkResult>)loader.GetDeviceProcAddr(device, "vkDebugMarkerSetObjectTagEXT");
        _vkDebugMarkerSetObjectNameEXT = (delegate* unmanaged[Cdecl]<VkDevice, VkDebugMarkerObjectNameInfoEXT*, VkResult>)loader.GetDeviceProcAddr(device, "vkDebugMarkerSetObjectNameEXT");
        _vkCmdDebugMarkerBeginEXT = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDebugMarkerMarkerInfoEXT*, void>)loader.GetDeviceProcAddr(device, "vkCmdDebugMarkerBeginEXT");
        _vkCmdDebugMarkerEndEXT = (delegate* unmanaged[Cdecl]<VkCommandBuffer, void>)loader.GetDeviceProcAddr(device, "vkCmdDebugMarkerEndEXT");
        _vkCmdDebugMarkerInsertEXT = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDebugMarkerMarkerInfoEXT*, void>)loader.GetDeviceProcAddr(device, "vkCmdDebugMarkerInsertEXT");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkDebugMarkerSetObjectTagEXT(VkDevice device, VkDebugMarkerObjectTagInfoEXT* pTagInfo)
    {
        return _vkDebugMarkerSetObjectTagEXT(device, pTagInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkDebugMarkerSetObjectNameEXT(VkDevice device, VkDebugMarkerObjectNameInfoEXT* pNameInfo)
    {
        return _vkDebugMarkerSetObjectNameEXT(device, pNameInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkCmdDebugMarkerBeginEXT(VkCommandBuffer commandBuffer, VkDebugMarkerMarkerInfoEXT* pMarkerInfo)
    {
        _vkCmdDebugMarkerBeginEXT(commandBuffer, pMarkerInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkCmdDebugMarkerEndEXT(VkCommandBuffer commandBuffer)
    {
        _vkCmdDebugMarkerEndEXT(commandBuffer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkCmdDebugMarkerInsertEXT(VkCommandBuffer commandBuffer, VkDebugMarkerMarkerInfoEXT* pMarkerInfo)
    {
        _vkCmdDebugMarkerInsertEXT(commandBuffer, pMarkerInfo);
    }
}