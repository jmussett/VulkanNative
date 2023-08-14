namespace VulkanNative;

public unsafe class VkExtDirectfbSurfaceExtension
{
    public delegate* unmanaged[Cdecl]<VkInstance, VkDirectFBSurfaceCreateInfoEXT*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> vkCreateDirectFBSurfaceEXT;
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint, nint*, VkBool32> vkGetPhysicalDeviceDirectFBPresentationSupportEXT;
}