using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtValidationCacheExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkValidationCacheCreateInfoEXT*, VkAllocationCallbacks*, VkValidationCacheEXT*, VkResult> _vkCreateValidationCacheEXT;
    private delegate* unmanaged[Cdecl]<VkDevice, VkValidationCacheEXT, VkAllocationCallbacks*, void> _vkDestroyValidationCacheEXT;
    private delegate* unmanaged[Cdecl]<VkDevice, VkValidationCacheEXT, uint, VkValidationCacheEXT*, VkResult> _vkMergeValidationCachesEXT;
    private delegate* unmanaged[Cdecl]<VkDevice, VkValidationCacheEXT, nint*, void*, VkResult> _vkGetValidationCacheDataEXT;

    public VkExtValidationCacheExtension(VkDevice device, IFunctionLoader loader)
    {
        _vkCreateValidationCacheEXT = (delegate* unmanaged[Cdecl]<VkDevice, VkValidationCacheCreateInfoEXT*, VkAllocationCallbacks*, VkValidationCacheEXT*, VkResult>)loader.GetDeviceProcAddr(device, "vkCreateValidationCacheEXT");
        _vkDestroyValidationCacheEXT = (delegate* unmanaged[Cdecl]<VkDevice, VkValidationCacheEXT, VkAllocationCallbacks*, void>)loader.GetDeviceProcAddr(device, "vkDestroyValidationCacheEXT");
        _vkMergeValidationCachesEXT = (delegate* unmanaged[Cdecl]<VkDevice, VkValidationCacheEXT, uint, VkValidationCacheEXT*, VkResult>)loader.GetDeviceProcAddr(device, "vkMergeValidationCachesEXT");
        _vkGetValidationCacheDataEXT = (delegate* unmanaged[Cdecl]<VkDevice, VkValidationCacheEXT, nint*, void*, VkResult>)loader.GetDeviceProcAddr(device, "vkGetValidationCacheDataEXT");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreateValidationCacheEXT(VkDevice device, VkValidationCacheCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkValidationCacheEXT* pValidationCache)
    {
        return _vkCreateValidationCacheEXT(device, pCreateInfo, pAllocator, pValidationCache);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkDestroyValidationCacheEXT(VkDevice device, VkValidationCacheEXT validationCache, VkAllocationCallbacks* pAllocator)
    {
        _vkDestroyValidationCacheEXT(device, validationCache, pAllocator);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkMergeValidationCachesEXT(VkDevice device, VkValidationCacheEXT dstCache, uint srcCacheCount, VkValidationCacheEXT* pSrcCaches)
    {
        return _vkMergeValidationCachesEXT(device, dstCache, srcCacheCount, pSrcCaches);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetValidationCacheDataEXT(VkDevice device, VkValidationCacheEXT validationCache, nint* pDataSize, void* pData)
    {
        return _vkGetValidationCacheDataEXT(device, validationCache, pDataSize, pData);
    }
}