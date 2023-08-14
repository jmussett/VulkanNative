namespace VulkanNative;

public unsafe class VkExtToolingInfoExtension
{
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint*, VkPhysicalDeviceToolProperties*, VkResult> vkGetPhysicalDeviceToolProperties;
}