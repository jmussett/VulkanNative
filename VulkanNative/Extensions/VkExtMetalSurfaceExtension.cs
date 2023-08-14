namespace VulkanNative;

public unsafe class VkExtMetalSurfaceExtension
{
    public delegate* unmanaged[Cdecl]<VkInstance, VkMetalSurfaceCreateInfoEXT*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> vkCreateMetalSurfaceEXT;
}