namespace VulkanNative;

public unsafe class VkGgpStreamDescriptorSurfaceExtension
{
    public delegate* unmanaged[Cdecl]<VkInstance, VkStreamDescriptorSurfaceCreateInfoGGP*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> vkCreateStreamDescriptorSurfaceGGP;
}