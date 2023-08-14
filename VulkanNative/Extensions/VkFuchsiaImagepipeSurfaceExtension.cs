namespace VulkanNative;

public unsafe class VkFuchsiaImagepipeSurfaceExtension
{
    public delegate* unmanaged[Cdecl]<VkInstance, VkImagePipeSurfaceCreateInfoFUCHSIA*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> vkCreateImagePipeSurfaceFUCHSIA;
}