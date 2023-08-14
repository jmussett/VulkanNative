namespace VulkanNative;

public unsafe class VkExtSampleLocationsExtension
{
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkSampleLocationsInfoEXT*, void> vkCmdSetSampleLocationsEXT;
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkSampleCountFlags, VkMultisamplePropertiesEXT*, void> vkGetPhysicalDeviceMultisamplePropertiesEXT;
}