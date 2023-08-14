﻿using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrMapMemory2Extension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkMemoryMapInfoKHR*, void**, VkResult> _vkMapMemory2KHR;
    private delegate* unmanaged[Cdecl]<VkDevice, VkMemoryUnmapInfoKHR*, VkResult> _vkUnmapMemory2KHR;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkMapMemory2KHR(VkDevice device, VkMemoryMapInfoKHR* pMemoryMapInfo, void** ppData)
    {
        return _vkMapMemory2KHR(device, pMemoryMapInfo, ppData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkUnmapMemory2KHR(VkDevice device, VkMemoryUnmapInfoKHR* pMemoryUnmapInfo)
    {
        return _vkUnmapMemory2KHR(device, pMemoryUnmapInfo);
    }
}