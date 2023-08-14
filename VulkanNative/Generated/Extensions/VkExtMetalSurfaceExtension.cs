using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtMetalSurfaceExtension
{
    private delegate* unmanaged[Cdecl]<VkInstance, VkMetalSurfaceCreateInfoEXT*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> _vkCreateMetalSurfaceEXT;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreateMetalSurfaceEXT(VkInstance instance, VkMetalSurfaceCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
    {
        return _vkCreateMetalSurfaceEXT(instance, pCreateInfo, pAllocator, pSurface);
    }
}