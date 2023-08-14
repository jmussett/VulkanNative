namespace VulkanNative;

public unsafe class VkKhrXlibSurfaceExtension
{
    public delegate* unmanaged[Cdecl]<VkInstance, VkXlibSurfaceCreateInfoKHR*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> vkCreateXlibSurfaceKHR;
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint, nint*, nint, VkBool32> vkGetPhysicalDeviceXlibPresentationSupportKHR;
}