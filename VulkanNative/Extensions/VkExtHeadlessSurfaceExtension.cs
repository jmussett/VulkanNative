namespace VulkanNative;

public unsafe class VkExtHeadlessSurfaceExtension
{
    public delegate* unmanaged[Cdecl]<VkInstance, VkHeadlessSurfaceCreateInfoEXT*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> vkCreateHeadlessSurfaceEXT;
}