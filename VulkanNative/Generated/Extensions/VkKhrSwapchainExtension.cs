using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrSwapchainExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainCreateInfoKHR*, VkAllocationCallbacks*, VkSwapchainKHR*, VkResult> _vkCreateSwapchainKHR;
    private delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, VkAllocationCallbacks*, void> _vkDestroySwapchainKHR;
    private delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, uint*, VkImage*, VkResult> _vkGetSwapchainImagesKHR;
    private delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, ulong, VkSemaphore, VkFence, uint*, VkResult> _vkAcquireNextImageKHR;
    private delegate* unmanaged[Cdecl]<VkQueue, VkPresentInfoKHR*, VkResult> _vkQueuePresentKHR;
    private delegate* unmanaged[Cdecl]<VkDevice, VkDeviceGroupPresentCapabilitiesKHR*, VkResult> _vkGetDeviceGroupPresentCapabilitiesKHR;
    private delegate* unmanaged[Cdecl]<VkDevice, VkSurfaceKHR, VkDeviceGroupPresentModeFlagsKHR*, VkResult> _vkGetDeviceGroupSurfacePresentModesKHR;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkSurfaceKHR, uint*, VkRect2D*, VkResult> _vkGetPhysicalDevicePresentRectanglesKHR;
    private delegate* unmanaged[Cdecl]<VkDevice, VkAcquireNextImageInfoKHR*, uint*, VkResult> _vkAcquireNextImage2KHR;

    public VkKhrSwapchainExtension(VkDevice device, IFunctionLoader loader)
    {
        _vkCreateSwapchainKHR = (delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainCreateInfoKHR*, VkAllocationCallbacks*, VkSwapchainKHR*, VkResult>)loader.GetDeviceProcAddr(device, "vkCreateSwapchainKHR");
        _vkDestroySwapchainKHR = (delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, VkAllocationCallbacks*, void>)loader.GetDeviceProcAddr(device, "vkDestroySwapchainKHR");
        _vkGetSwapchainImagesKHR = (delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, uint*, VkImage*, VkResult>)loader.GetDeviceProcAddr(device, "vkGetSwapchainImagesKHR");
        _vkAcquireNextImageKHR = (delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, ulong, VkSemaphore, VkFence, uint*, VkResult>)loader.GetDeviceProcAddr(device, "vkAcquireNextImageKHR");
        _vkQueuePresentKHR = (delegate* unmanaged[Cdecl]<VkQueue, VkPresentInfoKHR*, VkResult>)loader.GetDeviceProcAddr(device, "vkQueuePresentKHR");
        _vkGetDeviceGroupPresentCapabilitiesKHR = (delegate* unmanaged[Cdecl]<VkDevice, VkDeviceGroupPresentCapabilitiesKHR*, VkResult>)loader.GetDeviceProcAddr(device, "vkGetDeviceGroupPresentCapabilitiesKHR");
        _vkGetDeviceGroupSurfacePresentModesKHR = (delegate* unmanaged[Cdecl]<VkDevice, VkSurfaceKHR, VkDeviceGroupPresentModeFlagsKHR*, VkResult>)loader.GetDeviceProcAddr(device, "vkGetDeviceGroupSurfacePresentModesKHR");
        _vkGetPhysicalDevicePresentRectanglesKHR = (delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkSurfaceKHR, uint*, VkRect2D*, VkResult>)loader.GetDeviceProcAddr(device, "vkGetPhysicalDevicePresentRectanglesKHR");
        _vkAcquireNextImage2KHR = (delegate* unmanaged[Cdecl]<VkDevice, VkAcquireNextImageInfoKHR*, uint*, VkResult>)loader.GetDeviceProcAddr(device, "vkAcquireNextImage2KHR");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkCreateSwapchainKHR(VkDevice device, VkSwapchainCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSwapchainKHR* pSwapchain)
    {
        return _vkCreateSwapchainKHR(device, pCreateInfo, pAllocator, pSwapchain);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkDestroySwapchainKHR(VkDevice device, VkSwapchainKHR swapchain, VkAllocationCallbacks* pAllocator)
    {
        _vkDestroySwapchainKHR(device, swapchain, pAllocator);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkGetSwapchainImagesKHR(VkDevice device, VkSwapchainKHR swapchain, uint* pSwapchainImageCount, VkImage* pSwapchainImages)
    {
        return _vkGetSwapchainImagesKHR(device, swapchain, pSwapchainImageCount, pSwapchainImages);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkAcquireNextImageKHR(VkDevice device, VkSwapchainKHR swapchain, ulong timeout, VkSemaphore semaphore, VkFence fence, uint* pImageIndex)
    {
        return _vkAcquireNextImageKHR(device, swapchain, timeout, semaphore, fence, pImageIndex);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkQueuePresentKHR(VkQueue queue, VkPresentInfoKHR* pPresentInfo)
    {
        return _vkQueuePresentKHR(queue, pPresentInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkGetDeviceGroupPresentCapabilitiesKHR(VkDevice device, VkDeviceGroupPresentCapabilitiesKHR* pDeviceGroupPresentCapabilities)
    {
        return _vkGetDeviceGroupPresentCapabilitiesKHR(device, pDeviceGroupPresentCapabilities);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkGetDeviceGroupSurfacePresentModesKHR(VkDevice device, VkSurfaceKHR surface, VkDeviceGroupPresentModeFlagsKHR* pModes)
    {
        return _vkGetDeviceGroupSurfacePresentModesKHR(device, surface, pModes);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkGetPhysicalDevicePresentRectanglesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pRectCount, VkRect2D* pRects)
    {
        return _vkGetPhysicalDevicePresentRectanglesKHR(physicalDevice, surface, pRectCount, pRects);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkAcquireNextImage2KHR(VkDevice device, VkAcquireNextImageInfoKHR* pAcquireInfo, uint* pImageIndex)
    {
        return _vkAcquireNextImage2KHR(device, pAcquireInfo, pImageIndex);
    }
}