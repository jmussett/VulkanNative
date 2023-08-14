namespace VulkanNative;

public unsafe class VkExtAcquireXlibDisplayExtension
{
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, nint*, VkDisplayKHR, VkResult> vkAcquireXlibDisplayEXT;
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, nint*, nint, VkDisplayKHR*, VkResult> vkGetRandROutputDisplayEXT;
}