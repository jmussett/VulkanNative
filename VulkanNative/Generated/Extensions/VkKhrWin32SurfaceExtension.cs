using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrWin32SurfaceExtension
{
    private delegate* unmanaged[Cdecl]<VkInstance, VkWin32SurfaceCreateInfoKHR*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> _vkCreateWin32SurfaceKHR;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint, VkBool32> _vkGetPhysicalDeviceWin32PresentationSupportKHR;

    public VkKhrWin32SurfaceExtension(VkInstance instance, IFunctionLoader loader)
    {
        _vkCreateWin32SurfaceKHR = (delegate* unmanaged[Cdecl]<VkInstance, VkWin32SurfaceCreateInfoKHR*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult>)loader.GetInstanceProcAddr(instance, "vkCreateWin32SurfaceKHR");
        _vkGetPhysicalDeviceWin32PresentationSupportKHR = (delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint, VkBool32>)loader.GetInstanceProcAddr(instance, "vkGetPhysicalDeviceWin32PresentationSupportKHR");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkCreateWin32SurfaceKHR(VkInstance instance, VkWin32SurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
    {
        return _vkCreateWin32SurfaceKHR(instance, pCreateInfo, pAllocator, pSurface);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkBool32 vkGetPhysicalDeviceWin32PresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex)
    {
        return _vkGetPhysicalDeviceWin32PresentationSupportKHR(physicalDevice, queueFamilyIndex);
    }
}