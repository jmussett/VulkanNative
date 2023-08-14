namespace VulkanNative;

public unsafe class VkNvCopyMemoryIndirectExtension
{
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDeviceAddress, uint, uint, void> vkCmdCopyMemoryIndirectNV;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDeviceAddress, uint, uint, VkImage, VkImageLayout, VkImageSubresourceLayers*, void> vkCmdCopyMemoryToImageIndirectNV;
}