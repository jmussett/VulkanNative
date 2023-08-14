namespace VulkanNative;

public unsafe class VkKhrDisplayExtension
{
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint*, VkDisplayPropertiesKHR*, VkResult> vkGetPhysicalDeviceDisplayPropertiesKHR;
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint*, VkDisplayPlanePropertiesKHR*, VkResult> vkGetPhysicalDeviceDisplayPlanePropertiesKHR;
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint, uint*, VkDisplayKHR*, VkResult> vkGetDisplayPlaneSupportedDisplaysKHR;
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkDisplayKHR, uint*, VkDisplayModePropertiesKHR*, VkResult> vkGetDisplayModePropertiesKHR;
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkDisplayKHR, VkDisplayModeCreateInfoKHR*, VkAllocationCallbacks*, VkDisplayModeKHR*, VkResult> vkCreateDisplayModeKHR;
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkDisplayModeKHR, uint, VkDisplayPlaneCapabilitiesKHR*, VkResult> vkGetDisplayPlaneCapabilitiesKHR;
    public delegate* unmanaged[Cdecl]<VkInstance, VkDisplaySurfaceCreateInfoKHR*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> vkCreateDisplayPlaneSurfaceKHR;
}