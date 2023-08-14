namespace VulkanNative;

public unsafe class VkGoogleDisplayTimingExtension
{
    public delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, VkRefreshCycleDurationGOOGLE*, VkResult> vkGetRefreshCycleDurationGOOGLE;
    public delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, uint*, VkPastPresentationTimingGOOGLE*, VkResult> vkGetPastPresentationTimingGOOGLE;
}