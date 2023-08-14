using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkGgpStreamDescriptorSurfaceExtension
{
    private delegate* unmanaged[Cdecl]<VkInstance, VkStreamDescriptorSurfaceCreateInfoGGP*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> _vkCreateStreamDescriptorSurfaceGGP;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreateStreamDescriptorSurfaceGGP(VkInstance instance, VkStreamDescriptorSurfaceCreateInfoGGP* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
    {
        return _vkCreateStreamDescriptorSurfaceGGP(instance, pCreateInfo, pAllocator, pSurface);
    }
}