using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkGgpStreamDescriptorSurfaceExtension
{
    private delegate* unmanaged[Cdecl]<VkInstance, VkStreamDescriptorSurfaceCreateInfoGGP*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> _vkCreateStreamDescriptorSurfaceGGP;

    public VkGgpStreamDescriptorSurfaceExtension(VkInstance instance, IVulkanLoader loader)
    {
        _vkCreateStreamDescriptorSurfaceGGP = (delegate* unmanaged[Cdecl]<VkInstance, VkStreamDescriptorSurfaceCreateInfoGGP*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult>)loader.GetInstanceProcAddr(instance, "vkCreateStreamDescriptorSurfaceGGP");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreateStreamDescriptorSurfaceGGP(VkInstance instance, VkStreamDescriptorSurfaceCreateInfoGGP* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
    {
        return _vkCreateStreamDescriptorSurfaceGGP(instance, pCreateInfo, pAllocator, pSurface);
    }
}