namespace VulkanNative;

public unsafe class VkKhrAndroidSurfaceExtension
{
    public delegate* unmanaged[Cdecl]<VkInstance, VkAndroidSurfaceCreateInfoKHR*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> vkCreateAndroidSurfaceKHR;
}