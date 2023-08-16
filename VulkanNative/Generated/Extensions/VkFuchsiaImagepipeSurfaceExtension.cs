using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkFuchsiaImagepipeSurfaceExtension
{
    private delegate* unmanaged[Cdecl]<VkInstance, VkImagePipeSurfaceCreateInfoFUCHSIA*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> _vkCreateImagePipeSurfaceFUCHSIA;

    public VkFuchsiaImagepipeSurfaceExtension(VkInstance instance, IFunctionLoader loader)
    {
        _vkCreateImagePipeSurfaceFUCHSIA = (delegate* unmanaged[Cdecl]<VkInstance, VkImagePipeSurfaceCreateInfoFUCHSIA*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult>)loader.GetInstanceProcAddr(instance, "vkCreateImagePipeSurfaceFUCHSIA");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreateImagePipeSurfaceFUCHSIA(VkInstance instance, VkImagePipeSurfaceCreateInfoFUCHSIA* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
    {
        return _vkCreateImagePipeSurfaceFUCHSIA(instance, pCreateInfo, pAllocator, pSurface);
    }
}