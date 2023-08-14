namespace VulkanNative;

public unsafe class VkNvAcquireWinrtDisplayExtension
{
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkDisplayKHR, VkResult> vkAcquireWinrtDisplayNV;
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint, VkDisplayKHR*, VkResult> vkGetWinrtDisplayNV;
}