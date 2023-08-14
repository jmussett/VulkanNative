namespace VulkanNative;

public unsafe class VkExtValidationCacheExtension
{
    public delegate* unmanaged[Cdecl]<VkDevice, VkValidationCacheCreateInfoEXT*, VkAllocationCallbacks*, VkValidationCacheEXT*, VkResult> vkCreateValidationCacheEXT;
    public delegate* unmanaged[Cdecl]<VkDevice, VkValidationCacheEXT, VkAllocationCallbacks*, void> vkDestroyValidationCacheEXT;
    public delegate* unmanaged[Cdecl]<VkDevice, VkValidationCacheEXT, uint, VkValidationCacheEXT*, VkResult> vkMergeValidationCachesEXT;
    public delegate* unmanaged[Cdecl]<VkDevice, VkValidationCacheEXT, nint*, void*, VkResult> vkGetValidationCacheDataEXT;
}