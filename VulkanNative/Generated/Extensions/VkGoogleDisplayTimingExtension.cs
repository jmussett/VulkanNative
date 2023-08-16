using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkGoogleDisplayTimingExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, VkRefreshCycleDurationGOOGLE*, VkResult> _vkGetRefreshCycleDurationGOOGLE;
    private delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, uint*, VkPastPresentationTimingGOOGLE*, VkResult> _vkGetPastPresentationTimingGOOGLE;

    public VkGoogleDisplayTimingExtension(VkDevice device, IFunctionLoader loader)
    {
        _vkGetRefreshCycleDurationGOOGLE = (delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, VkRefreshCycleDurationGOOGLE*, VkResult>)loader.GetDeviceProcAddr(device, "vkGetRefreshCycleDurationGOOGLE");
        _vkGetPastPresentationTimingGOOGLE = (delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, uint*, VkPastPresentationTimingGOOGLE*, VkResult>)loader.GetDeviceProcAddr(device, "vkGetPastPresentationTimingGOOGLE");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetRefreshCycleDurationGOOGLE(VkDevice device, VkSwapchainKHR swapchain, VkRefreshCycleDurationGOOGLE* pDisplayTimingProperties)
    {
        return _vkGetRefreshCycleDurationGOOGLE(device, swapchain, pDisplayTimingProperties);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetPastPresentationTimingGOOGLE(VkDevice device, VkSwapchainKHR swapchain, uint* pPresentationTimingCount, VkPastPresentationTimingGOOGLE* pPresentationTimings)
    {
        return _vkGetPastPresentationTimingGOOGLE(device, swapchain, pPresentationTimingCount, pPresentationTimings);
    }
}