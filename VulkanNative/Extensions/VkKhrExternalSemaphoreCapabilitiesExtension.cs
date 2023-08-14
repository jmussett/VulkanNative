namespace VulkanNative;

public unsafe class VkKhrExternalSemaphoreCapabilitiesExtension
{
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceExternalSemaphoreInfo*, VkExternalSemaphoreProperties*, void> vkGetPhysicalDeviceExternalSemaphoreProperties;
}