﻿using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtMetalSurfaceExtension
{
    private delegate* unmanaged[Cdecl]<VkInstance, VkMetalSurfaceCreateInfoEXT*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> _vkCreateMetalSurfaceEXT;

    public VkExtMetalSurfaceExtension(VkInstance instance, IFunctionLoader loader)
    {
        _vkCreateMetalSurfaceEXT = (delegate* unmanaged[Cdecl]<VkInstance, VkMetalSurfaceCreateInfoEXT*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult>)loader.GetInstanceProcAddr(instance, "vkCreateMetalSurfaceEXT");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkCreateMetalSurfaceEXT(VkInstance instance, VkMetalSurfaceCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
    {
        return _vkCreateMetalSurfaceEXT(instance, pCreateInfo, pAllocator, pSurface);
    }
}