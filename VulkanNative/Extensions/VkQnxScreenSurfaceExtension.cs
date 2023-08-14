namespace VulkanNative;

public unsafe class VkQnxScreenSurfaceExtension
{
    public delegate* unmanaged[Cdecl]<VkInstance, VkScreenSurfaceCreateInfoQNX*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> vkCreateScreenSurfaceQNX;
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint, nint*, VkBool32> vkGetPhysicalDeviceScreenPresentationSupportQNX;
}