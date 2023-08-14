namespace VulkanNative;

public unsafe class VkKhrExternalMemoryCapabilitiesExtension
{
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceExternalBufferInfo*, VkExternalBufferProperties*, void> vkGetPhysicalDeviceExternalBufferProperties;
}