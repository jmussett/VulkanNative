namespace VulkanNative;

public unsafe class VkNnViSurfaceExtension
{
    public delegate* unmanaged[Cdecl]<VkInstance, VkViSurfaceCreateInfoNN*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> vkCreateViSurfaceNN;
}