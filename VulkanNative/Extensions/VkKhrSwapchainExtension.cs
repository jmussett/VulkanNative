namespace VulkanNative;

public unsafe class VkKhrSwapchainExtension
{
    public delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainCreateInfoKHR*, VkSwapchainCreateInfoKHR*, VkAllocationCallbacks*, VkSwapchainKHR*, VkResult> vkCreateSwapchainKHR;
    public delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, VkAllocationCallbacks*, void> vkDestroySwapchainKHR;
    public delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, uint*, VkImage*, VkResult> vkGetSwapchainImagesKHR;
    public delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, ulong, VkSemaphore, VkFence, uint*, VkResult> vkAcquireNextImageKHR;
    public delegate* unmanaged[Cdecl]<VkQueue, VkPresentInfoKHR*, VkResult> vkQueuePresentKHR;
    public delegate* unmanaged[Cdecl]<VkDevice, VkDeviceGroupPresentCapabilitiesKHR*, VkResult> vkGetDeviceGroupPresentCapabilitiesKHR;
    public delegate* unmanaged[Cdecl]<VkDevice, VkSurfaceKHR, VkDeviceGroupPresentModeFlagsKHR*, VkResult> vkGetDeviceGroupSurfacePresentModesKHR;
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkSurfaceKHR, uint*, VkRect2D*, VkResult> vkGetPhysicalDevicePresentRectanglesKHR;
    public delegate* unmanaged[Cdecl]<VkDevice, VkAcquireNextImageInfoKHR*, uint*, VkResult> vkAcquireNextImage2KHR;
}