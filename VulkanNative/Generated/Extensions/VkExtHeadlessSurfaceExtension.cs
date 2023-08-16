using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtHeadlessSurfaceExtension
{
    private delegate* unmanaged[Cdecl]<VkInstance, VkHeadlessSurfaceCreateInfoEXT*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> _vkCreateHeadlessSurfaceEXT;

    public VkExtHeadlessSurfaceExtension(VkInstance instance, IFunctionLoader loader)
    {
        _vkCreateHeadlessSurfaceEXT = (delegate* unmanaged[Cdecl]<VkInstance, VkHeadlessSurfaceCreateInfoEXT*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult>)loader.GetInstanceProcAddr(instance, "vkCreateHeadlessSurfaceEXT");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreateHeadlessSurfaceEXT(VkInstance instance, VkHeadlessSurfaceCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
    {
        return _vkCreateHeadlessSurfaceEXT(instance, pCreateInfo, pAllocator, pSurface);
    }
}