namespace VulkanNative;

public unsafe class VkKhrDrawIndirectCountExtension
{
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, VkDeviceSize, VkBuffer, VkDeviceSize, uint, uint, void> vkCmdDrawIndirectCount;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, VkDeviceSize, VkBuffer, VkDeviceSize, uint, uint, void> vkCmdDrawIndexedIndirectCount;
}