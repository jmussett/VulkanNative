namespace VulkanNative;

public unsafe class VkHuaweiInvocationMaskExtension
{
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkImageView, VkImageLayout, void> vkCmdBindInvocationMaskHUAWEI;
}