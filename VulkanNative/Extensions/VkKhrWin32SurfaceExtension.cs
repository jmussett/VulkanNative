namespace VulkanNative;

public unsafe class VkKhrWin32SurfaceExtension
{
    public delegate* unmanaged[Cdecl]<VkInstance, VkWin32SurfaceCreateInfoKHR*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> vkCreateWin32SurfaceKHR;
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint, VkBool32> vkGetPhysicalDeviceWin32PresentationSupportKHR;
}