namespace VulkanNative;

public unsafe class VkKhrXcbSurfaceExtension
{
    public delegate* unmanaged[Cdecl]<VkInstance, VkXcbSurfaceCreateInfoKHR*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> vkCreateXcbSurfaceKHR;
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint, nint*, nint, VkBool32> vkGetPhysicalDeviceXcbPresentationSupportKHR;
}