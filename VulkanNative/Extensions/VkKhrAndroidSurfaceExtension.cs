using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrAndroidSurfaceExtension
{
    private delegate* unmanaged[Cdecl]<VkInstance, VkAndroidSurfaceCreateInfoKHR*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> _vkCreateAndroidSurfaceKHR;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreateAndroidSurfaceKHR(VkInstance instance, VkAndroidSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
    {
        return _vkCreateAndroidSurfaceKHR(instance, pCreateInfo, pAllocator, pSurface);
    }
}