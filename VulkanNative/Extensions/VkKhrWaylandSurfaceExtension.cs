namespace VulkanNative;

public unsafe class VkKhrWaylandSurfaceExtension
{
    public delegate* unmanaged[Cdecl]<VkInstance, VkWaylandSurfaceCreateInfoKHR*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> vkCreateWaylandSurfaceKHR;
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint, nint*, VkBool32> vkGetPhysicalDeviceWaylandPresentationSupportKHR;
}