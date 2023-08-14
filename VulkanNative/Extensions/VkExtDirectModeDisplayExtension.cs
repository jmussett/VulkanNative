namespace VulkanNative;

public unsafe class VkExtDirectModeDisplayExtension
{
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkDisplayKHR, VkResult> vkReleaseDisplayEXT;
}