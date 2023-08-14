namespace VulkanNative;

public unsafe class VkExtFullScreenExclusiveExtension
{
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceSurfaceInfo2KHR*, uint*, VkPresentModeKHR*, VkResult> vkGetPhysicalDeviceSurfacePresentModes2EXT;
    public delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, VkResult> vkAcquireFullScreenExclusiveModeEXT;
    public delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, VkResult> vkReleaseFullScreenExclusiveModeEXT;
    public delegate* unmanaged[Cdecl]<VkDevice, VkPhysicalDeviceSurfaceInfo2KHR*, VkDeviceGroupPresentModeFlagsKHR*, VkResult> vkGetDeviceGroupSurfacePresentModes2EXT;
    public delegate* unmanaged[Cdecl]<VkDevice, VkPhysicalDeviceSurfaceInfo2KHR*, VkDeviceGroupPresentModeFlagsKHR*, VkResult> vkGetDeviceGroupSurfacePresentModes2EXT;
}