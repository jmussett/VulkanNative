using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkNnViSurfaceExtension
{
    private delegate* unmanaged[Cdecl]<VkInstance, VkViSurfaceCreateInfoNN*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> _vkCreateViSurfaceNN;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreateViSurfaceNN(VkInstance instance, VkViSurfaceCreateInfoNN* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
    {
        return _vkCreateViSurfaceNN(instance, pCreateInfo, pAllocator, pSurface);
    }
}