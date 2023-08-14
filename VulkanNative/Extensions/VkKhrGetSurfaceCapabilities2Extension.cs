namespace VulkanNative;

public unsafe class VkKhrGetSurfaceCapabilities2Extension
{
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceSurfaceInfo2KHR*, VkSurfaceCapabilities2KHR*, VkResult> vkGetPhysicalDeviceSurfaceCapabilities2KHR;
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceSurfaceInfo2KHR*, uint*, VkSurfaceFormat2KHR*, VkResult> vkGetPhysicalDeviceSurfaceFormats2KHR;
}