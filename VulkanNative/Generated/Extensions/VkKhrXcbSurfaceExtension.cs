using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrXcbSurfaceExtension
{
    private delegate* unmanaged[Cdecl]<VkInstance, VkXcbSurfaceCreateInfoKHR*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> _vkCreateXcbSurfaceKHR;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint, nint*, nint, VkBool32> _vkGetPhysicalDeviceXcbPresentationSupportKHR;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreateXcbSurfaceKHR(VkInstance instance, VkXcbSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
    {
        return _vkCreateXcbSurfaceKHR(instance, pCreateInfo, pAllocator, pSurface);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkBool32 VkGetPhysicalDeviceXcbPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, nint* connection, nint visual_id)
    {
        return _vkGetPhysicalDeviceXcbPresentationSupportKHR(physicalDevice, queueFamilyIndex, connection, visual_id);
    }
}