﻿using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrPresentWaitExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, ulong, ulong, VkResult> _vkWaitForPresentKHR;

    public VkKhrPresentWaitExtension(VkDevice device, IVulkanLoader loader)
    {
        _vkWaitForPresentKHR = (delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, ulong, ulong, VkResult>)loader.GetDeviceProcAddr(device, "vkWaitForPresentKHR");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkWaitForPresentKHR(VkDevice device, VkSwapchainKHR swapchain, ulong presentId, ulong timeout)
    {
        return _vkWaitForPresentKHR(device, swapchain, presentId, timeout);
    }
}