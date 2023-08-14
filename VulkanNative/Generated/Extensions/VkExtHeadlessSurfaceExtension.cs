using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtHeadlessSurfaceExtension
{
    private delegate* unmanaged[Cdecl]<VkInstance, VkHeadlessSurfaceCreateInfoEXT*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> _vkCreateHeadlessSurfaceEXT;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreateHeadlessSurfaceEXT(VkInstance instance, VkHeadlessSurfaceCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
    {
        return _vkCreateHeadlessSurfaceEXT(instance, pCreateInfo, pAllocator, pSurface);
    }
}