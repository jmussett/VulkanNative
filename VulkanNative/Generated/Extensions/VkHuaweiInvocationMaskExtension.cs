﻿using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkHuaweiInvocationMaskExtension
{
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkImageView, VkImageLayout, void> _vkCmdBindInvocationMaskHUAWEI;

    public VkHuaweiInvocationMaskExtension(VkDevice device, IFunctionLoader loader)
    {
        _vkCmdBindInvocationMaskHUAWEI = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkImageView, VkImageLayout, void>)loader.GetDeviceProcAddr(device, "vkCmdBindInvocationMaskHUAWEI");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkCmdBindInvocationMaskHUAWEI(VkCommandBuffer commandBuffer, VkImageView imageView, VkImageLayout imageLayout)
    {
        _vkCmdBindInvocationMaskHUAWEI(commandBuffer, imageView, imageLayout);
    }
}