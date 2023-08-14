namespace VulkanNative;

public unsafe class VkExtHostImageCopyExtension
{
    public delegate* unmanaged[Cdecl]<VkDevice, VkCopyMemoryToImageInfoEXT*, VkResult> vkCopyMemoryToImageEXT;
    public delegate* unmanaged[Cdecl]<VkDevice, VkCopyImageToMemoryInfoEXT*, VkResult> vkCopyImageToMemoryEXT;
    public delegate* unmanaged[Cdecl]<VkDevice, VkCopyImageToImageInfoEXT*, VkResult> vkCopyImageToImageEXT;
    public delegate* unmanaged[Cdecl]<VkDevice, uint, VkHostImageLayoutTransitionInfoEXT*, VkResult> vkTransitionImageLayoutEXT;
    public delegate* unmanaged[Cdecl]<VkDevice, VkImage, VkImageSubresource2KHR*, VkSubresourceLayout2KHR*, void> vkGetImageSubresourceLayout2KHR;
}