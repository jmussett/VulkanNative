namespace VulkanNative;

public unsafe class VkExtHdrMetadataExtension
{
    public delegate* unmanaged[Cdecl]<VkDevice, uint, VkSwapchainKHR*, VkHdrMetadataEXT*, void> vkSetHdrMetadataEXT;
}