﻿using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtHostQueryResetExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkQueryPool, uint, uint, void> _vkResetQueryPool;

    public VkExtHostQueryResetExtension(VkDevice device, IFunctionLoader loader)
    {
        _vkResetQueryPool = (delegate* unmanaged[Cdecl]<VkDevice, VkQueryPool, uint, uint, void>)loader.GetDeviceProcAddr(device, "vkResetQueryPool");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkResetQueryPool(VkDevice device, VkQueryPool queryPool, uint firstQuery, uint queryCount)
    {
        _vkResetQueryPool(device, queryPool, firstQuery, queryCount);
    }
}