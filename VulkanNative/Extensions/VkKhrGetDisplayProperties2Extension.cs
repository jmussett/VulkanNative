namespace VulkanNative;

public unsafe class VkKhrGetDisplayProperties2Extension
{
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint*, VkDisplayProperties2KHR*, VkResult> vkGetPhysicalDeviceDisplayProperties2KHR;
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint*, VkDisplayPlaneProperties2KHR*, VkResult> vkGetPhysicalDeviceDisplayPlaneProperties2KHR;
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkDisplayKHR, uint*, VkDisplayModeProperties2KHR*, VkResult> vkGetDisplayModeProperties2KHR;
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkDisplayPlaneInfo2KHR*, VkDisplayPlaneCapabilities2KHR*, VkResult> vkGetDisplayPlaneCapabilities2KHR;
}