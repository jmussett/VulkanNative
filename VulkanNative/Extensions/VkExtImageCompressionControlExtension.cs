namespace VulkanNative;

public unsafe class VkExtImageCompressionControlExtension
{
    public delegate* unmanaged[Cdecl]<VkDevice, VkImage, VkImageSubresource2KHR*, VkSubresourceLayout2KHR*, void> vkGetImageSubresourceLayout2KHR;
}