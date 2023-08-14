using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrWaylandSurfaceExtension
{
    private delegate* unmanaged[Cdecl]<VkInstance, VkWaylandSurfaceCreateInfoKHR*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> _vkCreateWaylandSurfaceKHR;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint, nint*, VkBool32> _vkGetPhysicalDeviceWaylandPresentationSupportKHR;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreateWaylandSurfaceKHR(VkInstance instance, VkWaylandSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
    {
        return _vkCreateWaylandSurfaceKHR(instance, pCreateInfo, pAllocator, pSurface);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkBool32 VkGetPhysicalDeviceWaylandPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, nint* display)
    {
        return _vkGetPhysicalDeviceWaylandPresentationSupportKHR(physicalDevice, queueFamilyIndex, display);
    }
}