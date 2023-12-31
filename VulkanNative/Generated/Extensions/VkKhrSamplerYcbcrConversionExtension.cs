﻿using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrSamplerYcbcrConversionExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkSamplerYcbcrConversionCreateInfo*, VkAllocationCallbacks*, VkSamplerYcbcrConversion*, VkResult> _vkCreateSamplerYcbcrConversion;
    private delegate* unmanaged[Cdecl]<VkDevice, VkSamplerYcbcrConversion, VkAllocationCallbacks*, void> _vkDestroySamplerYcbcrConversion;

    public VkKhrSamplerYcbcrConversionExtension(VkDevice device, IFunctionLoader loader)
    {
        _vkCreateSamplerYcbcrConversion = (delegate* unmanaged[Cdecl]<VkDevice, VkSamplerYcbcrConversionCreateInfo*, VkAllocationCallbacks*, VkSamplerYcbcrConversion*, VkResult>)loader.GetDeviceProcAddr(device, "vkCreateSamplerYcbcrConversion");
        _vkDestroySamplerYcbcrConversion = (delegate* unmanaged[Cdecl]<VkDevice, VkSamplerYcbcrConversion, VkAllocationCallbacks*, void>)loader.GetDeviceProcAddr(device, "vkDestroySamplerYcbcrConversion");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkCreateSamplerYcbcrConversion(VkDevice device, VkSamplerYcbcrConversionCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSamplerYcbcrConversion* pYcbcrConversion)
    {
        return _vkCreateSamplerYcbcrConversion(device, pCreateInfo, pAllocator, pYcbcrConversion);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkDestroySamplerYcbcrConversion(VkDevice device, VkSamplerYcbcrConversion ycbcrConversion, VkAllocationCallbacks* pAllocator)
    {
        _vkDestroySamplerYcbcrConversion(device, ycbcrConversion, pAllocator);
    }
}