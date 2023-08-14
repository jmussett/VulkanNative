using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrWin32SurfaceExtension
{
    private delegate* unmanaged[Cdecl]<VkInstance, VkWin32SurfaceCreateInfoKHR*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> _vkCreateWin32SurfaceKHR;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint, VkBool32> _vkGetPhysicalDeviceWin32PresentationSupportKHR;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreateWin32SurfaceKHR(VkInstance instance, VkWin32SurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
    {
        return _vkCreateWin32SurfaceKHR(instance, pCreateInfo, pAllocator, pSurface);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkBool32 VkGetPhysicalDeviceWin32PresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex)
    {
        return _vkGetPhysicalDeviceWin32PresentationSupportKHR(physicalDevice, queueFamilyIndex);
    }
}