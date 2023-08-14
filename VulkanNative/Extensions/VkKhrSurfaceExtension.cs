namespace VulkanNative;

public unsafe class VkKhrSurfaceExtension
{
    public delegate* unmanaged[Cdecl]<VkInstance, VkSurfaceKHR, VkAllocationCallbacks*, void> vkDestroySurfaceKHR;
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint, VkSurfaceKHR, VkBool32*, VkResult> vkGetPhysicalDeviceSurfaceSupportKHR;
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkSurfaceKHR, VkSurfaceCapabilitiesKHR*, VkResult> vkGetPhysicalDeviceSurfaceCapabilitiesKHR;
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkSurfaceKHR, uint*, VkSurfaceFormatKHR*, VkResult> vkGetPhysicalDeviceSurfaceFormatsKHR;
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkSurfaceKHR, uint*, VkPresentModeKHR*, VkResult> vkGetPhysicalDeviceSurfacePresentModesKHR;
}