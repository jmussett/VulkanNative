namespace VulkanNative;

public unsafe class VkKhrMaintenance5Extension
{
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, VkDeviceSize, VkDeviceSize, VkIndexType, void> vkCmdBindIndexBuffer2KHR;
    public delegate* unmanaged[Cdecl]<VkDevice, VkRenderingAreaInfoKHR*, VkExtent2D*, void> vkGetRenderingAreaGranularityKHR;
    public delegate* unmanaged[Cdecl]<VkDevice, VkDeviceImageSubresourceInfoKHR*, VkSubresourceLayout2KHR*, void> vkGetDeviceImageSubresourceLayoutKHR;
    public delegate* unmanaged[Cdecl]<VkDevice, VkImage, VkImageSubresource2KHR*, VkSubresourceLayout2KHR*, void> vkGetImageSubresourceLayout2KHR;
}