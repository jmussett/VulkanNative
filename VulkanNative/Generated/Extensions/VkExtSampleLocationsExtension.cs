using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtSampleLocationsExtension
{
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkSampleLocationsInfoEXT*, void> _vkCmdSetSampleLocationsEXT;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkSampleCountFlags, VkMultisamplePropertiesEXT*, void> _vkGetPhysicalDeviceMultisamplePropertiesEXT;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetSampleLocationsEXT(VkCommandBuffer commandBuffer, VkSampleLocationsInfoEXT* pSampleLocationsInfo)
    {
        _vkCmdSetSampleLocationsEXT(commandBuffer, pSampleLocationsInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetPhysicalDeviceMultisamplePropertiesEXT(VkPhysicalDevice physicalDevice, VkSampleCountFlags samples, VkMultisamplePropertiesEXT* pMultisampleProperties)
    {
        _vkGetPhysicalDeviceMultisamplePropertiesEXT(physicalDevice, samples, pMultisampleProperties);
    }
}