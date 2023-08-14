namespace VulkanNative;

public unsafe class VkExtCalibratedTimestampsExtension
{
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint*, VkTimeDomainEXT*, VkResult> vkGetPhysicalDeviceCalibrateableTimeDomainsEXT;
    public delegate* unmanaged[Cdecl]<VkDevice, uint, VkCalibratedTimestampInfoEXT*, ulong*, ulong*, VkResult> vkGetCalibratedTimestampsEXT;
}