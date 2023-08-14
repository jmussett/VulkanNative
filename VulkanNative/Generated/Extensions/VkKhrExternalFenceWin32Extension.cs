﻿using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrExternalFenceWin32Extension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkImportFenceWin32HandleInfoKHR*, VkResult> _vkImportFenceWin32HandleKHR;
    private delegate* unmanaged[Cdecl]<VkDevice, VkFenceGetWin32HandleInfoKHR*, nint*, VkResult> _vkGetFenceWin32HandleKHR;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkImportFenceWin32HandleKHR(VkDevice device, VkImportFenceWin32HandleInfoKHR* pImportFenceWin32HandleInfo)
    {
        return _vkImportFenceWin32HandleKHR(device, pImportFenceWin32HandleInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetFenceWin32HandleKHR(VkDevice device, VkFenceGetWin32HandleInfoKHR* pGetWin32HandleInfo, nint* pHandle)
    {
        return _vkGetFenceWin32HandleKHR(device, pGetWin32HandleInfo, pHandle);
    }
}