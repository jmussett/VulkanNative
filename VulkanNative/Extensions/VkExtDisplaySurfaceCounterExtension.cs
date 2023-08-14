namespace VulkanNative;

public unsafe class VkExtDisplaySurfaceCounterExtension
{
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkSurfaceKHR, VkSurfaceCapabilities2EXT*, VkResult> vkGetPhysicalDeviceSurfaceCapabilities2EXT;
}