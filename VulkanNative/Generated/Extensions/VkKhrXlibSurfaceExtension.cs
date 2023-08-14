using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrXlibSurfaceExtension
{
    private delegate* unmanaged[Cdecl]<VkInstance, VkXlibSurfaceCreateInfoKHR*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> _vkCreateXlibSurfaceKHR;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint, nint*, nint, VkBool32> _vkGetPhysicalDeviceXlibPresentationSupportKHR;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreateXlibSurfaceKHR(VkInstance instance, VkXlibSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
    {
        return _vkCreateXlibSurfaceKHR(instance, pCreateInfo, pAllocator, pSurface);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkBool32 VkGetPhysicalDeviceXlibPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, nint* dpy, nint visualID)
    {
        return _vkGetPhysicalDeviceXlibPresentationSupportKHR(physicalDevice, queueFamilyIndex, dpy, visualID);
    }
}