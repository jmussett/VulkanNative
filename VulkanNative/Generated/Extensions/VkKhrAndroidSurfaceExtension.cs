using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrAndroidSurfaceExtension
{
    private delegate* unmanaged[Cdecl]<VkInstance, VkAndroidSurfaceCreateInfoKHR*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> _vkCreateAndroidSurfaceKHR;

    public VkKhrAndroidSurfaceExtension(VkInstance instance, IFunctionLoader loader)
    {
        _vkCreateAndroidSurfaceKHR = (delegate* unmanaged[Cdecl]<VkInstance, VkAndroidSurfaceCreateInfoKHR*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult>)loader.GetInstanceProcAddr(instance, "vkCreateAndroidSurfaceKHR");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkCreateAndroidSurfaceKHR(VkInstance instance, VkAndroidSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
    {
        return _vkCreateAndroidSurfaceKHR(instance, pCreateInfo, pAllocator, pSurface);
    }
}