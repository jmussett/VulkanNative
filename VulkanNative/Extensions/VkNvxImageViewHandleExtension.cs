namespace VulkanNative;

public unsafe class VkNvxImageViewHandleExtension
{
    public delegate* unmanaged[Cdecl]<VkDevice, VkImageViewHandleInfoNVX*, uint> vkGetImageViewHandleNVX;
    public delegate* unmanaged[Cdecl]<VkDevice, VkImageView, VkImageViewAddressPropertiesNVX*, VkResult> vkGetImageViewAddressNVX;
}