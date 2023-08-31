using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkQnxScreenSurfaceExtension
{
    private delegate* unmanaged[Cdecl]<VkInstance, VkScreenSurfaceCreateInfoQNX*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> _vkCreateScreenSurfaceQNX;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint, nint*, VkBool32> _vkGetPhysicalDeviceScreenPresentationSupportQNX;

    public VkQnxScreenSurfaceExtension(VkInstance instance, IFunctionLoader loader)
    {
        _vkCreateScreenSurfaceQNX = (delegate* unmanaged[Cdecl]<VkInstance, VkScreenSurfaceCreateInfoQNX*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult>)loader.GetInstanceProcAddr(instance, "vkCreateScreenSurfaceQNX");
        _vkGetPhysicalDeviceScreenPresentationSupportQNX = (delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint, nint*, VkBool32>)loader.GetInstanceProcAddr(instance, "vkGetPhysicalDeviceScreenPresentationSupportQNX");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkCreateScreenSurfaceQNX(VkInstance instance, VkScreenSurfaceCreateInfoQNX* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
    {
        return _vkCreateScreenSurfaceQNX(instance, pCreateInfo, pAllocator, pSurface);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkBool32 vkGetPhysicalDeviceScreenPresentationSupportQNX(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, nint* window)
    {
        return _vkGetPhysicalDeviceScreenPresentationSupportQNX(physicalDevice, queueFamilyIndex, window);
    }
}