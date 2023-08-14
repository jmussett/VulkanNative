namespace VulkanNative;

public unsafe class VkKhrExternalFenceCapabilitiesExtension
{
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceExternalFenceInfo*, VkExternalFenceProperties*, void> vkGetPhysicalDeviceExternalFenceProperties;
}