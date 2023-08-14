namespace VulkanNative;

public unsafe class VkExtAcquireDrmDisplayExtension
{
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, int, VkDisplayKHR, VkResult> vkAcquireDrmDisplayEXT;
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, int, uint, VkDisplayKHR*, VkResult> vkGetDrmDisplayEXT;
}